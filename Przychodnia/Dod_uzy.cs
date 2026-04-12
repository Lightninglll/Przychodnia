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
    public partial class Dod_uzy : Form
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";

        public Dod_uzy()
        {
            InitializeComponent();
        }

        private void Dodaj_uz_Click(object sender, EventArgs e)
        {
            var imie = txt_imie.Text.Trim();
            var nazwisko = txt_nazwisko.Text.Trim();
            var dataUrodzeniaText = txt_datauro.Text.Trim();
            var email = textBox3.Text.Trim();
            var telefon = textBox2.Text.Trim();
            var haslo = textBox1.Text;

            if (string.IsNullOrEmpty(imie) ||
                string.IsNullOrEmpty(nazwisko) ||
                string.IsNullOrEmpty(dataUrodzeniaText) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(telefon) ||
                string.IsNullOrEmpty(haslo))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(dataUrodzeniaText, out DateTime dataUrodzenia))
            {
                MessageBox.Show("Nieprawidłowy format daty urodzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                conn.Open();

                using (var cmdCheckEmail = new Microsoft.Data.SqlClient.SqlCommand("SELECT COUNT(1) FROM dbo.urzytkownicy WHERE Email = @email", conn))
                {
                    cmdCheckEmail.Parameters.AddWithValue("@email", email);
                    int emailCount = Convert.ToInt32(cmdCheckEmail.ExecuteScalar() ?? 0);
                    if (emailCount > 0)
                    {
                        MessageBox.Show("Podany email już istnieje w bazie.", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                using (var cmdCheckPhone = new Microsoft.Data.SqlClient.SqlCommand("SELECT COUNT(1) FROM dbo.urzytkownicy WHERE Phone = @phone", conn))
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

                using var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn);

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
                    MessageBox.Show("Użytkownik został dodany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_imie.Clear();
                    txt_nazwisko.Clear();
                    txt_datauro.Clear();
                    textBox3.Clear();
                    textBox2.Clear();
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Nie udało się dodać użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd połączenia / zapytania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();
            this.Close();
        }
    }
}