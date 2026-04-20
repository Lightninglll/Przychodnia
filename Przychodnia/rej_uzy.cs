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
    public partial class rej_uzy : Form
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";

        public rej_uzy()
        {
            InitializeComponent();
        }

        private void rej_uzy_Load(object sender, EventArgs e)
        {

        }

        private void rej_Click(object sender, EventArgs e)
        {

            var imie = textBox1.Text.Trim();
            var nazwisko = textBox2.Text.Trim();
            var dataUrodzeniaText = textBox3.Text.Trim();
            var email = textBox4.Text.Trim();
            var telefon = textBox5.Text.Trim();
            var haslo = textBox6.Text;
            var hasloPowtorz = textBox7.Text;

            if (string.IsNullOrEmpty(imie) ||
                string.IsNullOrEmpty(nazwisko) ||
                string.IsNullOrEmpty(dataUrodzeniaText) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(telefon) ||
                string.IsNullOrEmpty(haslo) ||
                string.IsNullOrEmpty(hasloPowtorz))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (haslo != hasloPowtorz)
            {
                MessageBox.Show("Hasła nie są takie same.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(dataUrodzeniaText, out DateTime dataUrodzenia))
            {
                MessageBox.Show("Nieprawidłowy format daty urodzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                using (var cmdCheckEmail = new SqlCommand("SELECT COUNT(1) FROM dbo.urzytkownicy WHERE Email = @email", conn))
                {
                    cmdCheckEmail.Parameters.AddWithValue("@email", email);
                    int emailCount = Convert.ToInt32(cmdCheckEmail.ExecuteScalar() ?? 0);
                    if (emailCount > 0)
                    {
                        MessageBox.Show("Podany email już istnieje w bazie.", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                using (var cmdCheckPhone = new SqlCommand("SELECT COUNT(1) FROM dbo.urzytkownicy WHERE Phone = @phone", conn))
                {
                    cmdCheckPhone.Parameters.AddWithValue("@phone", telefon);
                    int phoneCount = Convert.ToInt32(cmdCheckPhone.ExecuteScalar() ?? 0);
                    if (phoneCount > 0)
                    {
                        MessageBox.Show("Podany numer telefonu już istnieje w bazie.", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                const string sql = @"
INSERT INTO dbo.urzytkownicy (FirstName, LastName, DateOfBirth, Phone, Email, Password)
VALUES (@imie, @nazwisko, @data, @telefon, @email, @password)";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@imie", imie);
                cmd.Parameters.AddWithValue("@nazwisko", nazwisko);
                cmd.Parameters.AddWithValue("@data", dataUrodzenia);
                cmd.Parameters.AddWithValue("@telefon", telefon);
                cmd.Parameters.AddWithValue("@email", email);

                var p = cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar, 256);
                p.Value = haslo;

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Rejestracja przebiegła pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var loginForm = new Log_urzy();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nie udało się zarejestrować użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd połączenia / zapytania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }
    }
}
