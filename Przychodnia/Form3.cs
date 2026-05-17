using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Przychodnia
{
	public partial class Form3 : Form
	{
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";

        // kontrolki rezerwacji (tworzone raz)
        private Panel reservationPanel;
        private ComboBox lekarzComboBox;
        private ComboBox godzinaComboBox;
        private ComboBox specjalizacjaComboBox;
        private DateTimePicker datePicker;
        private Button potwierdzButton;

        // id zalogowanego użytkownika
        private int loggedUserId = 0;

        public Form3()
		{
			InitializeComponent();
		}

        // nowy konstruktor - przyjmujemy displayName oraz id użytkownika
        public Form3(string displayName, int userId)
        {
            InitializeComponent();
            loggedUserId = userId;
            if (!string.IsNullOrEmpty(displayName) && imienazwisko != null)
            {
                imienazwisko.Text = displayName;
            }
        }

		private void Form3_Load(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		// przycisk "Rezerwacja wizyty" - pokazuje kontrolki rezerwacji
		private void button1_Click(object sender, EventArgs e)
		{
            ShowReservationControls();
		}

        private void ShowReservationControls()
        {
            if (reservationPanel != null)
            {
                reservationPanel.Visible = true;
                LoadSpecializations();
                return;
            }

            // oblicz pozycję tak żeby nie nachodził na lewy panel menu
            int desiredX = 260;
            var leftMenu = this.Controls.Find("panelMenu", true).FirstOrDefault() as Panel;
            if (leftMenu != null) desiredX = leftMenu.Bounds.Right + 20;
            int defaultWidth = 760;
            int panelWidth = Math.Min(defaultWidth, Math.Max(400, this.ClientSize.Width - desiredX - 20));
            int panelHeight = 420;

            reservationPanel = new Panel
            {
                Name = "reservationPanel",
                Location = new Point(desiredX, 80),
                Size = new Size(panelWidth, panelHeight),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.WhiteSmoke,
                AutoScroll = true
            };

            var lekarzLabel = new Label { Text = "Wybierz lekarza:", Location = new Point(10, 15), AutoSize = true };
            lekarzComboBox = new ComboBox { Name = "lekarzComboBox", Location = new Point(160, 12), Width = Math.Max(200, panelWidth - 200), DropDownStyle = ComboBoxStyle.DropDownList };

            var specjalizacjaLabel = new Label { Text = "Wybierz specjalizację:", Location = new Point(10, 55), AutoSize = true };
            specjalizacjaComboBox = new ComboBox { Name = "specjalizacjaComboBox", Location = new Point(160, 52), Width = Math.Max(200, panelWidth - 200), DropDownStyle = ComboBoxStyle.DropDownList };

            var dataLabel = new Label { Text = "Wybierz datę (do 30 dni):", Location = new Point(10, 95), AutoSize = true };
            datePicker = new DateTimePicker { Name = "datePicker", Location = new Point(160, 92), Width = 150, Format = DateTimePickerFormat.Short };
            datePicker.MinDate = DateTime.Today;
            datePicker.MaxDate = DateTime.Today.AddDays(30);

            var godzinaLabel = new Label { Text = "Wybierz godzinę:", Location = new Point(10, 135), AutoSize = true };
            godzinaComboBox = new ComboBox { Name = "godzinaComboBox", Location = new Point(160, 132), Width = 150, DropDownStyle = ComboBoxStyle.DropDownList };

            // godziny od 8 do 20 co godzinę
            godzinaComboBox.Items.Clear();
            for (int h = 8; h <= 20; h++)
            {
                godzinaComboBox.Items.Add($"{h:00}:00");
            }
            if (godzinaComboBox.Items.Count > 0) godzinaComboBox.SelectedIndex = 0;

            potwierdzButton = new Button { Name = "potwierdzButton", Text = "Zarezerwuj", Location = new Point(160, 180), Width = 120 };

            reservationPanel.Controls.Add(lekarzLabel);
            reservationPanel.Controls.Add(lekarzComboBox);
            reservationPanel.Controls.Add(specjalizacjaLabel);
            reservationPanel.Controls.Add(specjalizacjaComboBox);
            reservationPanel.Controls.Add(dataLabel);
            reservationPanel.Controls.Add(datePicker);
            reservationPanel.Controls.Add(godzinaLabel);
            reservationPanel.Controls.Add(godzinaComboBox);
            reservationPanel.Controls.Add(potwierdzButton);

            this.Controls.Add(reservationPanel);
            reservationPanel.BringToFront();

            specjalizacjaComboBox.SelectedIndexChanged += (s, e) =>
            {
                LoadDoctorsBySpecialization(specjalizacjaComboBox.SelectedItem?.ToString());
            };

            potwierdzButton.Click += PotwierdzButton_Click;

            LoadSpecializations();
        }

        // załaduj wszystkie specjalizacje z bazy
        private void LoadSpecializations()
        {
            try
            {
                specjalizacjaComboBox.Items.Clear();
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                using var cmd = new SqlCommand("SELECT DISTINCT Specialization FROM dbo.lekarze WHERE Specialization IS NOT NULL ORDER BY Specialization", conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    specjalizacjaComboBox.Items.Add(reader.GetString(0));
                }
                // dodaj opcję "Wszyscy"
                specjalizacjaComboBox.Items.Insert(0, "Wszyscy");
                specjalizacjaComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania specjalizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadDoctorsBySpecialization(specjalizacjaComboBox.SelectedItem?.ToString());
            }
        }

        // załaduj lekarzy, opcjonalnie filtrując po specjalizacji
        private void LoadDoctorsBySpecialization(string specialization)
        {
            try
            {
                lekarzComboBox.Items.Clear();
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                string sql;
                if (string.IsNullOrEmpty(specialization) || specialization == "Wszyscy")
                {
                    sql = "SELECT id_lekarz, FirstName + ' ' + LastName AS FullName FROM dbo.lekarze ORDER BY FullName";
                    using var cmd = new SqlCommand(sql, conn);
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lekarzComboBox.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.IsDBNull(1) ? string.Empty : reader.GetString(1)));
                    }
                }
                else
                {
                    sql = "SELECT id_lekarz, FirstName + ' ' + LastName AS FullName FROM dbo.lekarze WHERE specialization = @spec ORDER BY FullName";
                    using var cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@spec", specialization);
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lekarzComboBox.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.IsDBNull(1) ? string.Empty : reader.GetString(1)));
                    }
                }

                lekarzComboBox.DisplayMember = "Value";
                lekarzComboBox.ValueMember = "Key";

                if (lekarzComboBox.Items.Count > 0)
                    lekarzComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania lekarzy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // potwierdzenie rezerwacji - zapis do bazy wraz z id zalogowanego użytkownika
        private void PotwierdzButton_Click(object? sender, EventArgs e)
        {
            if (lekarzComboBox.SelectedItem == null)
            {
                MessageBox.Show("Wybierz lekarza.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (specjalizacjaComboBox.SelectedItem == null)
            {
                MessageBox.Show("Wybierz specjalizację.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (datePicker == null || godzinaComboBox.SelectedItem == null)
            {
                MessageBox.Show("Wybierz datę i godzinę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int lekarzId = 0;
            if (lekarzComboBox.SelectedItem is KeyValuePair<int, string> kv)
                lekarzId = kv.Key;
            else if (lekarzComboBox.SelectedValue is int v)
                lekarzId = v;

            if (lekarzId == 0)
            {
                MessageBox.Show("Nieprawidłowy lekarz.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (loggedUserId == 0)
            {
                MessageBox.Show("Brak identyfikatora zalogowanego użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var chosenDate = datePicker.Value.Date;
            var chosenTimeText = godzinaComboBox.SelectedItem.ToString(); // "09:00"
            if (!TimeSpan.TryParse(chosenTimeText, out TimeSpan time))
            {
                MessageBox.Show("Nieprawidłowa godzina.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var appointmentDate = chosenDate; // data wizyty (tylko data)
            var appointmentTime = time.ToString(@"hh\:mm"); // format "HH:mm"

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                // Dopasuj nazwę tabeli jeśli u Ciebie inna (np. dbo.wizyty)
                const string sql = @"
INSERT INTO dbo.wizyty (id_lekarz, id_uzytkownik, Data_Wizyty, godzina, data)
VALUES (@id_lekarz, @id_uzytkownik, @Data_Wizyty, @godzina, @data)";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_lekarz", lekarzId);
                cmd.Parameters.AddWithValue("@id_uzytkownik", loggedUserId);
                cmd.Parameters.AddWithValue("@Data_Wizyty", appointmentDate);
                cmd.Parameters.AddWithValue("@godzina", appointmentTime);
                cmd.Parameters.AddWithValue("@data", DateTime.Now); // data utworzenia rekordu

                int affected = cmd.ExecuteNonQuery();
                if (affected > 0)
                {
                    MessageBox.Show("Rezerwacja została zapisana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reservationPanel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Nie udało się zapisać rezerwacji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd zapisu rezerwacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{

		}
	}
}
