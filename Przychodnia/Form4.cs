using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Przychodnia
{

    public partial class Form4 : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
        // zarządzanie specjalizacjami
        private DataGridView dgvSpecjalizacje;
        private Button btnAddSpecjalizacja;
        private Button btnEditSpecjalizacja;
        private Button btnDeleteSpecjalizacja;


        // zarządzanie wizytami - dynamiczne kontrolki
        private DataGridView dgvWizyty;
        private Button btnAddWizyta;
        private Button btnEditWizyta;
        private Button btnDeleteWizyta;

        public Form4()
        {
            InitializeComponent();

            if (dgv1 != null) dgv1.Visible = false;
            if (button6 != null) button6.Visible = false;
            if (button7 != null) button7.Visible = false;
            if (button8 != null) button8.Visible = false;

            // ukryj kontrolki zarządzania wizytami i specjalizacjami na start
            if (dgvWizyty != null) dgvWizyty.Visible = false;
            if (btnAddWizyta != null) btnAddWizyta.Visible = false;
            if (btnEditWizyta != null) btnEditWizyta.Visible = false;
            if (btnDeleteWizyta != null) btnDeleteWizyta.Visible = false;
            if (dgvSpecjalizacje != null) dgvSpecjalizacje.Visible = false;
            if (btnAddSpecjalizacja != null) btnAddSpecjalizacja.Visible = false;
            if (btnEditSpecjalizacja != null) btnEditSpecjalizacja.Visible = false;
            if (btnDeleteSpecjalizacja != null) btnDeleteSpecjalizacja.Visible = false;

            if (labelId != null) labelId.Visible = false;
            if (txt_id != null) txt_id.Visible = false;
            if (btnPotwierdz != null) btnPotwierdz.Visible = false;

            if (pobierz_lekarzy != null) pobierz_lekarzy.Visible = false;
            if (dgv2 != null) dgv2.Visible = false;

            if (Dodaj_lekarza != null) Dodaj_lekarza.Click += Dodaj_lekarza_Click;
            if (Usun_lekarza != null) Usun_lekarza.Click += Usun_lekarza_Click;

            if (button8 != null) button8.Click += button8_Click;
        }

        public Form4(string loggedDisplayName) : this()
        {
            if (!string.IsNullOrEmpty(loggedDisplayName) && Zalog != null)
            {
                Zalog.Text = loggedDisplayName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Microsoft.Data.SqlClient.SqlConnection sqlCon = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            {
                sqlCon.Open();
                Microsoft.Data.SqlClient.SqlDataAdapter sqlDa = new Microsoft.Data.SqlClient.SqlDataAdapter("SELECT * FROM dbo.urzytkownicy", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            var toHide = new Control[] { dgv1, button6, button7, button8, labelId, txt_id, btnPotwierdz, pobierz_lekarzy, dgv2, Dodaj_lekarza, Usun_lekarza, id_lekarza, txt_lekarz_id, potwierdz_lek };
            foreach (var c in toHide)
            {
                if (c != null) c.Visible = false;
            }

            var panelList = this.Controls.Find("panelList", true).FirstOrDefault();
            var panelEdit = this.Controls.Find("panelEdit", true).FirstOrDefault();

            if (panelList != null && panelEdit != null)
            {
                panelList.Visible = false;
                panelEdit.Visible = true;
            }
            else
            {
                string[] showNames = { "textBoxName", "buttonSave", "buttonCancel" };
                foreach (var name in showNames)
                {
                    var ctrl = this.Controls.Find(name, true).FirstOrDefault();
                    if (ctrl != null) ctrl.Visible = true;
                }
            }

            if (pobierz_lekarzy != null) pobierz_lekarzy.Visible = true;
            if (dgv2 != null) dgv2.Visible = true;

            if (Dodaj_lekarza != null) Dodaj_lekarza.Visible = true;
            if (Usun_lekarza != null) Usun_lekarza.Visible = true;

            if (pobierz_lekarzy != null)
            {
                pobierz_lekarzy.PerformClick();
            }
            else
            {
                pobierz_lekarzy_Click(this, EventArgs.Empty);
            }

            // ukryj kontrolki zarządzania wizytami jeśli istnieją
            if (dgvWizyty != null) dgvWizyty.Visible = false;
            if (btnAddWizyta != null) btnAddWizyta.Visible = false;
            if (btnEditWizyta != null) btnEditWizyta.Visible = false;
            if (btnDeleteWizyta != null) btnDeleteWizyta.Visible = false;
            // ukryj kontrolki specjalizacji
            if (dgvSpecjalizacje != null) dgvSpecjalizacje.Visible = false;
            if (btnAddSpecjalizacja != null) btnAddSpecjalizacja.Visible = false;
            if (btnEditSpecjalizacja != null) btnEditSpecjalizacja.Visible = false;
            if (btnDeleteSpecjalizacja != null) btnDeleteSpecjalizacja.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);

            if (pobierz_lekarzy != null) pobierz_lekarzy.Visible = false;
            if (dgv2 != null) dgv2.Visible = false;
            if (Dodaj_lekarza != null) Dodaj_lekarza.Visible = false;
            if (Usun_lekarza != null) Usun_lekarza.Visible = false;

            if (id_lekarza != null) id_lekarza.Visible = false;
            if (txt_lekarz_id != null) txt_lekarz_id.Visible = false;
            if (potwierdz_lek != null) potwierdz_lek.Visible = false;

            var panelList = this.Controls.Find("panelList", true).FirstOrDefault();
            var panelEdit = this.Controls.Find("panelEdit", true).FirstOrDefault();
            if (panelList != null) panelList.Visible = false;
            if (panelEdit != null) panelEdit.Visible = false;

            if (dgv1 != null) dgv1.Visible = true;
            if (button6 != null) button6.Visible = true;
            if (button7 != null) button7.Visible = true;
            if (button8 != null) button8.Visible = true;

            // ukryj kontrolki zarządzania wizytami
            if (dgvWizyty != null) dgvWizyty.Visible = false;
            if (btnAddWizyta != null) btnAddWizyta.Visible = false;
            if (btnEditWizyta != null) btnEditWizyta.Visible = false;
            if (btnDeleteWizyta != null) btnDeleteWizyta.Visible = false;

            // ukryj kontrolki specjalizacji
            if (dgvSpecjalizacje != null) dgvSpecjalizacje.Visible = false;
            if (btnAddSpecjalizacja != null) btnAddSpecjalizacja.Visible = false;
            if (btnEditSpecjalizacja != null) btnEditSpecjalizacja.Visible = false;
            if (btnDeleteSpecjalizacja != null) btnDeleteSpecjalizacja.Visible = false;

            if (labelId != null) labelId.Visible = false;
            if (txt_id != null) txt_id.Visible = false;
            if (btnPotwierdz != null) btnPotwierdz.Visible = false;

            if (button6 != null) button6.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);

            // ukryj inne panele
            if (dgv1 != null) dgv1.Visible = false;
            if (button6 != null) button6.Visible = false;
            if (button7 != null) button7.Visible = false;
            if (button8 != null) button8.Visible = false;

            if (labelId != null) labelId.Visible = false;
            if (txt_id != null) txt_id.Visible = false;
            if (btnPotwierdz != null) btnPotwierdz.Visible = false;

            if (pobierz_lekarzy != null) pobierz_lekarzy.Visible = false;
            if (dgv2 != null) dgv2.Visible = false;
            if (Dodaj_lekarza != null) Dodaj_lekarza.Visible = false;
            if (Usun_lekarza != null) Usun_lekarza.Visible = false;

            if (id_lekarza != null) id_lekarza.Visible = false;
            if (txt_lekarz_id != null) txt_lekarz_id.Visible = false;
            if (potwierdz_lek != null) potwierdz_lek.Visible = false;

            // pokaż zarządzanie wizytami
            ShowWizytyControls();
            // ukryj specjalizacje
            if (dgvSpecjalizacje != null) dgvSpecjalizacje.Visible = false;
            if (btnAddSpecjalizacja != null) btnAddSpecjalizacja.Visible = false;
            if (btnEditSpecjalizacja != null) btnEditSpecjalizacja.Visible = false;
            if (btnDeleteSpecjalizacja != null) btnDeleteSpecjalizacja.Visible = false;
        }

        private void ShowWizytyControls()
        {
            // jeśli już utworzone, pokaż i odśwież
            if (dgvWizyty != null)
            {
                dgvWizyty.Visible = true;
                btnAddWizyta.Visible = true;
                btnEditWizyta.Visible = true;
                btnDeleteWizyta.Visible = true;
                LoadWizyty();
                return;
            }

            // umieść w tym samym miejscu co dgv2, aby nie nakładać na siebie
            var anchor = this.Controls.Find("dgv2", true).FirstOrDefault() as DataGridView;
            if (anchor != null)
            {
                dgvWizyty = new DataGridView
                {
                    Name = "dgvWizyty",
                    Location = anchor.Location,
                    Size = anchor.Size,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect
                };
            }
            else
            {
                int desiredX = 260;
                var leftMenu = this.Controls.Find("panelMenu", true).FirstOrDefault() as Panel;
                if (leftMenu != null) desiredX = leftMenu.Bounds.Right + 20;
                int gridWidth = Math.Min(1000, Math.Max(600, this.ClientSize.Width - desiredX - 40));
                int gridHeight = Math.Min(600, this.ClientSize.Height - 160);

                dgvWizyty = new DataGridView
                {
                    Name = "dgvWizyty",
                    Location = new Point(desiredX, 140),
                    Size = new Size(gridWidth, gridHeight),
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect
                };
            }

            int btnY = 80;

            btnAddWizyta = new Button { Text = "Dodaj wizytę", Size = new Size(120, 30) };
            btnEditWizyta = new Button { Text = "Edytuj wizytę", Size = new Size(120, 30) };
            btnDeleteWizyta = new Button { Text = "Usuń wizytę", Size = new Size(120, 30) };

            btnAddWizyta.Click += BtnAddWizyta_Click;
            btnEditWizyta.Click += BtnEditWizyta_Click;
            btnDeleteWizyta.Click += BtnDeleteWizyta_Click;

            this.Controls.Add(dgvWizyty);
            // przyciski umieść nad gridem w linii jak w pozostałych modułach
            var anchorBtnY = dgvWizyty.Location.Y - 60;
            var anchorBtnX = dgvWizyty.Location.X;
            btnAddWizyta.Location = new Point(anchorBtnX, anchorBtnY);
            btnEditWizyta.Location = new Point(anchorBtnX + 140, anchorBtnY);
            btnDeleteWizyta.Location = new Point(anchorBtnX + 280, anchorBtnY);
            this.Controls.Add(btnAddWizyta);
            this.Controls.Add(btnEditWizyta);
            this.Controls.Add(btnDeleteWizyta);

            dgvWizyty.BringToFront();
            btnAddWizyta.BringToFront();
            btnEditWizyta.BringToFront();
            btnDeleteWizyta.BringToFront();

            LoadWizyty();
        }

        private void LoadWizyty()
        {
            try
            {
                using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                conn.Open();
                string sql = @"SELECT w.id_wizyta AS Id, w.Data_Wizyty, ISNULL(l.FirstName + ' ' + l.LastName, '') AS Lekarz, ISNULL(u.FirstName + ' ' + u.LastName, '') AS Pacjent, w.opis
                               FROM dbo.wizyty w
                               LEFT JOIN dbo.lekarze l ON w.id_lekarz = l.id_lekarz
                               LEFT JOIN dbo.urzytkownicy u ON w.id_uzytkownik = u.id_uzytkownik
                               ORDER BY w.Data_Wizyty DESC";
                using var da = new Microsoft.Data.SqlClient.SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dgvWizyty != null)
                {
                    dgvWizyty.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania wizyt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddWizyta_Click(object? sender, EventArgs e)
        {
            ShowWizytaEditor();
        }

        private void BtnEditWizyta_Click(object? sender, EventArgs e)
        {
            if (dgvWizyty == null || dgvWizyty.CurrentRow == null) { MessageBox.Show("Wybierz wizytę do edycji.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            var id = dgvWizyty.CurrentRow.Cells["Id"].Value;
            if (id == null) { MessageBox.Show("Nie można odczytać ID."); return; }
            ShowWizytaEditor(Convert.ToInt32(id));
        }

        private void BtnDeleteWizyta_Click(object? sender, EventArgs e)
        {
            if (dgvWizyty == null || dgvWizyty.CurrentRow == null) { MessageBox.Show("Wybierz wizytę do usunięcia.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            var id = dgvWizyty.CurrentRow.Cells["Id"].Value;
            if (id == null) { MessageBox.Show("Nie można odczytać ID."); return; }
            var intId = Convert.ToInt32(id);
            var confirm = MessageBox.Show($"Usunąć wizytę o ID = {intId}?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;
            try
            {
                using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                using var cmd = new Microsoft.Data.SqlClient.SqlCommand("DELETE FROM dbo.wizyty WHERE id_wizyta = @id", conn);
                cmd.Parameters.AddWithValue("@id", intId);
                conn.Open();
                int affected = cmd.ExecuteNonQuery();
                if (affected > 0) { MessageBox.Show("Usunięto wizytę.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information); LoadWizyty(); }
                else MessageBox.Show("Nie znaleziono wizyty.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd usuwania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowWizytaEditor(int? editId = null)
        {
            // modalny formularz do dodawania/edycji
            using var f = new Form { Text = editId == null ? "Dodaj wizytę" : "Edytuj wizytę", Size = new Size(500, 360), StartPosition = FormStartPosition.CenterParent };

            var lblData = new Label { Text = "Data i godzina:", Location = new Point(10, 20), AutoSize = true };
            var dtPicker = new DateTimePicker { Format = DateTimePickerFormat.Custom, CustomFormat = "yyyy-MM-dd HH:mm", ShowUpDown = true, Location = new Point(120, 16), Width = 200 };

            var lblLekarz = new Label { Text = "Lekarz:", Location = new Point(10, 60), AutoSize = true };
            var cbLekarz = new ComboBox { Location = new Point(120, 56), Width = 300, DropDownStyle = ComboBoxStyle.DropDownList };

            var lblPacjent = new Label { Text = "Pacjent:", Location = new Point(10, 100), AutoSize = true };
            var cbPacjent = new ComboBox { Location = new Point(120, 96), Width = 300, DropDownStyle = ComboBoxStyle.DropDownList };

            var lblOpis = new Label { Text = "Opis:", Location = new Point(10, 140), AutoSize = true };
            var tbOpis = new TextBox { Location = new Point(120, 136), Width = 300, Height = 100, Multiline = true, ScrollBars = ScrollBars.Vertical };

            var btnOk = new Button { Text = "Zapisz", Location = new Point(120, 260), Size = new Size(100, 30) };
            var btnCancel = new Button { Text = "Anuluj", Location = new Point(240, 260), Size = new Size(100, 30) };

            f.Controls.AddRange(new Control[] { lblData, dtPicker, lblLekarz, cbLekarz, lblPacjent, cbPacjent, lblOpis, tbOpis, btnOk, btnCancel });

            // załaduj lekarzy i pacjentów
            try
            {
                using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                conn.Open();
                using var cmdL = new Microsoft.Data.SqlClient.SqlCommand("SELECT id_lekarz, FirstName + ' ' + LastName AS FullName FROM dbo.lekarze ORDER BY FullName", conn);
                using var rdr = cmdL.ExecuteReader();
                while (rdr.Read()) cbLekarz.Items.Add(new KeyValuePair<int, string>(rdr.GetInt32(0), rdr.GetString(1)));
                cbLekarz.DisplayMember = "Value"; cbLekarz.ValueMember = "Key";
                rdr.Close();

                using var cmdP = new Microsoft.Data.SqlClient.SqlCommand("SELECT id_uzytkownik, FirstName + ' ' + LastName AS FullName FROM dbo.urzytkownicy ORDER BY FullName", conn);
                using var rdr2 = cmdP.ExecuteReader();
                while (rdr2.Read()) cbPacjent.Items.Add(new KeyValuePair<int, string>(rdr2.GetInt32(0), rdr2.GetString(1)));
                cbPacjent.DisplayMember = "Value"; cbPacjent.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania list", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (editId != null)
            {
                // wczytaj dane rekordu
                try
                {
                    using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                    conn.Open();
                    using var cmd = new Microsoft.Data.SqlClient.SqlCommand("SELECT Data_Wizyty, id_lekarz, id_uzytkownik, opis FROM dbo.wizyty WHERE id_wizyta = @id", conn);
                    cmd.Parameters.AddWithValue("@id", editId.Value);
                    using var rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        dtPicker.Value = rdr.IsDBNull(0) ? DateTime.Now : rdr.GetDateTime(0);
                        var idL = rdr.IsDBNull(1) ? 0 : rdr.GetInt32(1);
                        var idU = rdr.IsDBNull(2) ? 0 : rdr.GetInt32(2);
                        tbOpis.Text = rdr.IsDBNull(3) ? string.Empty : rdr.GetString(3);

                        // ustaw selekcje
                        for (int i = 0; i < cbLekarz.Items.Count; i++) if (((KeyValuePair<int, string>)cbLekarz.Items[i]).Key == idL) { cbLekarz.SelectedIndex = i; break; }
                        for (int i = 0; i < cbPacjent.Items.Count; i++) if (((KeyValuePair<int, string>)cbPacjent.Items[i]).Key == idU) { cbPacjent.SelectedIndex = i; break; }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd ładowania rekordu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnCancel.Click += (s, e) => f.Close();
            btnOk.Click += (s, e) =>
            {
                // walidacja
                if (cbLekarz.SelectedItem == null || cbPacjent.SelectedItem == null) { MessageBox.Show("Wybierz lekarza i pacjenta.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                var lekarzId = ((KeyValuePair<int, string>)cbLekarz.SelectedItem).Key;
                var pacjentId = ((KeyValuePair<int, string>)cbPacjent.SelectedItem).Key;
                var dataWiz = dtPicker.Value;
                var opis = tbOpis.Text ?? string.Empty;

                try
                {
                    using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                    conn.Open();
                    Microsoft.Data.SqlClient.SqlCommand cmd;
                    if (editId == null)
                    {
                        cmd = new Microsoft.Data.SqlClient.SqlCommand("INSERT INTO dbo.wizyty (Data_Wizyty, id_lekarz, id_uzytkownik, opis, data) VALUES (@dataWiz, @idL, @idU, @opis, @data)", conn);
                        cmd.Parameters.AddWithValue("@dataWiz", dataWiz);
                        cmd.Parameters.AddWithValue("@idL", lekarzId);
                        cmd.Parameters.AddWithValue("@idU", pacjentId);
                        cmd.Parameters.AddWithValue("@opis", opis);
                        cmd.Parameters.AddWithValue("@data", dataWiz.Date);
                        int aff = cmd.ExecuteNonQuery();
                        if (aff > 0) MessageBox.Show("Dodano wizytę.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cmd = new Microsoft.Data.SqlClient.SqlCommand("UPDATE dbo.wizyty SET Data_Wizyty = @dataWiz, id_lekarz = @idL, id_uzytkownik = @idU, opis = @opis WHERE id_wizyta = @id", conn);
                        cmd.Parameters.AddWithValue("@dataWiz", dataWiz);
                        cmd.Parameters.AddWithValue("@idL", lekarzId);
                        cmd.Parameters.AddWithValue("@idU", pacjentId);
                        cmd.Parameters.AddWithValue("@opis", opis);
                        cmd.Parameters.AddWithValue("@id", editId.Value);
                        int aff = cmd.ExecuteNonQuery();
                        if (aff > 0) MessageBox.Show("Zaktualizowano wizytę.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadWizyty();
                    f.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            f.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);

            if (dgv1 != null) dgv1.Visible = false;
            if (button6 != null) button6.Visible = false;
            if (button7 != null) button7.Visible = false;
            if (button8 != null) button8.Visible = false;

            if (labelId != null) labelId.Visible = false;
            if (txt_id != null) txt_id.Visible = false;
            if (btnPotwierdz != null) btnPotwierdz.Visible = false;

            if (pobierz_lekarzy != null) pobierz_lekarzy.Visible = false;
            if (dgv2 != null) dgv2.Visible = false;
            if (Dodaj_lekarza != null) Dodaj_lekarza.Visible = false;
            if (Usun_lekarza != null) Usun_lekarza.Visible = false;

            if (id_lekarza != null) id_lekarza.Visible = false;
            if (txt_lekarz_id != null) txt_lekarz_id.Visible = false;
            if (potwierdz_lek != null) potwierdz_lek.Visible = false;

            // pokaż zarządzanie specjalizacjami
            ShowSpecControls();
        }

        private void ShowSpecControls()
        {
            // ukryj kontrolki wizyt
            if (dgvWizyty != null) dgvWizyty.Visible = false;
            if (btnAddWizyta != null) btnAddWizyta.Visible = false;
            if (btnEditWizyta != null) btnEditWizyta.Visible = false;
            if (btnDeleteWizyta != null) btnDeleteWizyta.Visible = false;

            if (dgvSpecjalizacje != null)
            {
                dgvSpecjalizacje.Visible = true;
                btnAddSpecjalizacja.Visible = true;
                btnEditSpecjalizacja.Visible = true;
                btnDeleteSpecjalizacja.Visible = true;
                LoadSpecjalizacje();
                return;
            }

            // umieść grid specjalizacji w miejscu dgv2
            var anchor2 = this.Controls.Find("dgv2", true).FirstOrDefault() as DataGridView;
            if (anchor2 != null)
            {
                dgvSpecjalizacje = new DataGridView
                {
                    Name = "dgvSpecjalizacje",
                    Location = anchor2.Location,
                    Size = anchor2.Size,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect
                };
            }
            else
            {
                int desiredX = 260;
                var leftMenu = this.Controls.Find("panelMenu", true).FirstOrDefault() as Panel;
                if (leftMenu != null) desiredX = leftMenu.Bounds.Right + 20;
                int gridWidth = Math.Min(1000, Math.Max(600, this.ClientSize.Width - desiredX - 40));
                int gridHeight = Math.Min(600, this.ClientSize.Height - 160);

                dgvSpecjalizacje = new DataGridView
                {
                    Name = "dgvSpecjalizacje",
                    Location = new Point(desiredX, 140),
                    Size = new Size(gridWidth, gridHeight),
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect
                };
            }

            int btnY = 80;

            btnAddSpecjalizacja = new Button { Name = "btnAddSpecjalizacja", Text = "Dodaj specjalizację", Size = new Size(150, 30) };
            btnEditSpecjalizacja = new Button { Name = "btnEditSpecjalizacja", Text = "Edytuj specjalizację", Size = new Size(150, 30) };
            btnDeleteSpecjalizacja = new Button { Name = "btnDeleteSpecjalizacja", Text = "Usuń specjalizację", Size = new Size(150, 30) };

            btnAddSpecjalizacja.Click += BtnAddSpecjalizacja_Click;
            btnEditSpecjalizacja.Click += BtnEditSpecjalizacja_Click;
            btnDeleteSpecjalizacja.Click += BtnDeleteSpecjalizacja_Click;

            this.Controls.Add(dgvSpecjalizacje);
            var anchorBtnY2 = dgvSpecjalizacje.Location.Y - 60;
            var anchorBtnX2 = dgvSpecjalizacje.Location.X;
            btnAddSpecjalizacja.Location = new Point(anchorBtnX2, anchorBtnY2);
            btnEditSpecjalizacja.Location = new Point(anchorBtnX2 + 160, anchorBtnY2);
            btnDeleteSpecjalizacja.Location = new Point(anchorBtnX2 + 320, anchorBtnY2);

            // unikaj dodawania duplikatów — sprawdź czy już istnieją
            if (this.Controls.Find(btnAddSpecjalizacja.Name, true).Length == 0) this.Controls.Add(btnAddSpecjalizacja);
            if (this.Controls.Find(btnEditSpecjalizacja.Name, true).Length == 0) this.Controls.Add(btnEditSpecjalizacja);
            if (this.Controls.Find(btnDeleteSpecjalizacja.Name, true).Length == 0) this.Controls.Add(btnDeleteSpecjalizacja);

            dgvSpecjalizacje.BringToFront();
            btnAddSpecjalizacja.BringToFront();
            btnEditSpecjalizacja.BringToFront();
            btnDeleteSpecjalizacja.BringToFront();

            LoadSpecjalizacje();
        }

        private void LoadSpecjalizacje()
        {
            try
            {
                using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                conn.Open();
                string sql = @"SELECT DISTINCT Specialization AS Specjalizacja FROM dbo.lekarze ORDER BY Specialization";
                using var da = new Microsoft.Data.SqlClient.SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dgvSpecjalizacje != null) dgvSpecjalizacje.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd ładowania specjalizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddSpecjalizacja_Click(object? sender, EventArgs e)
        {
            using var f = new Form { Text = "Dodaj specjalizację", Size = new Size(400, 180), StartPosition = FormStartPosition.CenterParent };
            var lbl = new Label { Text = "Nazwa:", Location = new Point(10, 20), AutoSize = true };
            var tb = new TextBox { Location = new Point(80, 18), Width = 280 };
            var btnOk = new Button { Text = "Dodaj", Location = new Point(80, 60), Size = new Size(100, 30) };
            var btnCancel = new Button { Text = "Anuluj", Location = new Point(200, 60), Size = new Size(100, 30) };
            f.Controls.AddRange(new Control[] { lbl, tb, btnOk, btnCancel });
            btnCancel.Click += (s, ev) => f.Close();
            btnOk.Click += (s, ev) =>
            {
                var name = tb.Text.Trim();
                if (string.IsNullOrEmpty(name)) { MessageBox.Show("Podaj nazwę specjalizacji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                try
                {
                    using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                    conn.Open();
                    // zapis do kolumny Specialization w tabeli lekarze jako unikalna wartość
                    using var cmd = new Microsoft.Data.SqlClient.SqlCommand("INSERT INTO dbo.lekarze (FirstName, LastName, Email, Specialization, Password) VALUES ('', '', '', @spec, '')", conn);
                    cmd.Parameters.AddWithValue("@spec", name);
                    cmd.ExecuteNonQuery();
                    LoadSpecjalizacje();
                    f.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd dodawania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            f.ShowDialog(this);
        }

        private void BtnEditSpecjalizacja_Click(object? sender, EventArgs e)
        {
            if (dgvSpecjalizacje == null || dgvSpecjalizacje.CurrentRow == null) { MessageBox.Show("Wybierz specjalizację do edycji.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            var current = dgvSpecjalizacje.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
            using var f = new Form { Text = "Edytuj specjalizację", Size = new Size(400, 180), StartPosition = FormStartPosition.CenterParent };
            var lbl = new Label { Text = "Nazwa:", Location = new Point(10, 20), AutoSize = true };
            var tb = new TextBox { Location = new Point(80, 18), Width = 280, Text = current };
            var btnOk = new Button { Text = "Zapisz", Location = new Point(80, 60), Size = new Size(100, 30) };
            var btnCancel = new Button { Text = "Anuluj", Location = new Point(200, 60), Size = new Size(100, 30) };
            f.Controls.AddRange(new Control[] { lbl, tb, btnOk, btnCancel });
            btnCancel.Click += (s, ev) => f.Close();
            btnOk.Click += (s, ev) =>
            {
                var name = tb.Text.Trim();
                if (string.IsNullOrEmpty(name)) { MessageBox.Show("Podaj nazwę specjalizacji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                try
                {
                    using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                    conn.Open();
                    // zaktualizuj wszystkie wpisy lekarzy z tą specjalizacją na nową nazwę
                    using var cmd = new Microsoft.Data.SqlClient.SqlCommand("UPDATE dbo.lekarze SET Specialization = @new WHERE Specialization = @old", conn);
                    cmd.Parameters.AddWithValue("@new", name);
                    cmd.Parameters.AddWithValue("@old", current);
                    cmd.ExecuteNonQuery();
                    LoadSpecjalizacje();
                    f.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd edycji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            f.ShowDialog(this);
        }

        private void BtnDeleteSpecjalizacja_Click(object? sender, EventArgs e)
        {
            if (dgvSpecjalizacje == null || dgvSpecjalizacje.CurrentRow == null) { MessageBox.Show("Wybierz specjalizację do usunięcia.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            var current = dgvSpecjalizacje.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
            var confirm = MessageBox.Show($"Usunąć specjalizację '{current}'?\nSpowoduje to ustawienie pustej specjalizacji dla lekarzy.", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;
            try
            {
                using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                conn.Open();
                using var cmd = new Microsoft.Data.SqlClient.SqlCommand("UPDATE dbo.lekarze SET Specialization = NULL WHERE Specialization = @old", conn);
                cmd.Parameters.AddWithValue("@old", current);
                cmd.ExecuteNonQuery();
                LoadSpecjalizacje();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd usuwania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (labelId != null) labelId.Visible = true;
            if (txt_id != null)
            {
                txt_id.Visible = true;
                txt_id.Text = string.Empty;
                txt_id.Focus();
            }
            if (btnPotwierdz != null) btnPotwierdz.Visible = true;
        }

        private void btnPotwierdz_Click(object sender, EventArgs e)
        {
            if (txt_id == null)
                return;

            var idText = txt_id.Text.Trim();
            if (string.IsNullOrEmpty(idText))
            {
                MessageBox.Show("Wprowadź ID użytkownika.", "Brak ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("ID musi być liczbą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Potwierdzasz usunięcie użytkownika o ID = {id}?", "Potwierdź usunięcie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                using var cmd = new Microsoft.Data.SqlClient.SqlCommand("DELETE FROM dbo.urzytkownicy WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                int affected = cmd.ExecuteNonQuery();

                if (affected > 0)
                {
                    MessageBox.Show($"Usunięto użytkownika o ID = {id}.", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (button6 != null) button6.PerformClick();

                    if (labelId != null) labelId.Visible = false;
                    if (txt_id != null) txt_id.Visible = false;
                    if (btnPotwierdz != null) btnPotwierdz.Visible = false;
                }
                else
                {
                    MessageBox.Show($"Brak użytkownika o ID = {id}.", "Nie znaleziono", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd połączenia / zapytania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dod_uzy f1 = new Dod_uzy();
            f1.Show();
            this.Close();
        }

        private void pobierz_lekarzy_Click(object sender, EventArgs e)
        {
            using (Microsoft.Data.SqlClient.SqlConnection sqlCon = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            {
                sqlCon.Open();
                Microsoft.Data.SqlClient.SqlDataAdapter sqlDa = new Microsoft.Data.SqlClient.SqlDataAdapter("SELECT * FROM dbo.lekarze", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                if (dgv2 != null) dgv2.DataSource = dtbl;
            }
        }

        private void Dodaj_lekarza_Click(object sender, EventArgs e)
        {
            Dod_lek dodLekForm = new Dod_lek();
            dodLekForm.Show();
            this.Close();
        }

        private void Usun_lekarza_Click(object sender, EventArgs e)
        {
            if (id_lekarza != null) id_lekarza.Visible = true;
            if (txt_lekarz_id != null)
            {
                txt_lekarz_id.Visible = true;
                txt_lekarz_id.Text = string.Empty;
                txt_lekarz_id.Focus();
            }
            if (potwierdz_lek != null) potwierdz_lek.Visible = true;
        }

        private void potwierdz_lek_Click(object sender, EventArgs e)
        {
            if (txt_lekarz_id == null)
                return;

            var idText = txt_lekarz_id.Text.Trim();
            if (string.IsNullOrEmpty(idText))
            {
                MessageBox.Show("Wprowadź ID lekarza.", "Brak ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("ID musi być liczbą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Potwierdzasz usunięcie lekarza o ID = {id}?", "Potwierdź usunięcie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                using var cmd = new Microsoft.Data.SqlClient.SqlCommand("DELETE FROM dbo.lekarze WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                int affected = cmd.ExecuteNonQuery();

                if (affected > 0)
                {
                    MessageBox.Show($"Usunięto lekarza o ID = {id}.", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (pobierz_lekarzy != null) pobierz_lekarzy.PerformClick();

                    if (id_lekarza != null) id_lekarza.Visible = false;
                    if (txt_lekarz_id != null) txt_lekarz_id.Visible = false;
                    if (potwierdz_lek != null) potwierdz_lek.Visible = false;
                }
                else
                {
                    MessageBox.Show($"Brak lekarza o ID = {id}.", "Nie znaleziono", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd połączenia / zapytania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void potwierdz_lek_Click_1(object sender, EventArgs e)
        {
            if (txt_id == null)
                return;

            var idText = txt_lekarz_id.Text.Trim();
            if (string.IsNullOrEmpty(idText))
            {
                MessageBox.Show("Wprowadź ID Lekarza.", "Brak ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("ID musi być liczbą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Potwierdzasz usunięcie Lekarza o ID = {id}?", "Potwierdź usunięcie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                using var cmd = new Microsoft.Data.SqlClient.SqlCommand("DELETE FROM dbo.lekarze WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                int affected = cmd.ExecuteNonQuery();

                if (affected > 0)
                {
                    MessageBox.Show($"Usunięto lekarza o ID = {id}.", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (button6 != null) button6.PerformClick();

                    if (labelId != null) labelId.Visible = false;
                    if (txt_id != null) txt_id.Visible = false;
                    if (btnPotwierdz != null) btnPotwierdz.Visible = false;
                }
                else
                {
                    MessageBox.Show($"Brak lekarza o ID = {id}.", "Nie znaleziono", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd połączenia / zapytania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dodaj_lekarza_Click_1(object sender, EventArgs e)
        {

        }

        private void SetActiveMenuButton(Button active)
        {
            var buttons = new[] { button1, button2, button3, button4 };

            foreach (var b in buttons)
            {
                if (b == null) continue;
                b.BackColor = Color.FromArgb(51, 51, 76);
                b.ForeColor = Color.Gainsboro;
            }

            if (active != null)
            {
                active.BackColor = Color.FromArgb(39, 39, 58);
                active.ForeColor = Color.White;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}