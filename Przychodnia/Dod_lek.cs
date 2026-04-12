using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace Przychodnia
{
    public partial class Dod_lek : Form
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";

        public Dod_lek()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Dodaj_lek_Click(object sender, EventArgs e)
        {
            var imie = textBox1.Text.Trim();
            var nazwisko = textBox2.Text.Trim();
            var email = textBox3.Text.Trim();
            var specjalizacja = textBox4.Text.Trim();
            var telefon = textBox5.Text.Trim();
            var haslo = textBox6.Text;
            var numerLicencji = textBox7.Text.Trim();

            if (string.IsNullOrEmpty(imie) ||
                string.IsNullOrEmpty(nazwisko) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(specjalizacja) ||
                string.IsNullOrEmpty(telefon) ||
                string.IsNullOrEmpty(haslo) ||
                string.IsNullOrEmpty(numerLicencji))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var licensePattern = new Regex(@"^LIC-PL-\d{4}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);
            if (!licensePattern.IsMatch(numerLicencji))
            {
                MessageBox.Show("Numer licencji musi mieć format: LIC-PL-XXXX (X - cyfra).", "Nieprawidłowy numer licencji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                using (var cmdCheckEmail = new SqlCommand("SELECT COUNT(1) FROM dbo.lekarze WHERE Email = @email", conn))
                {
                    cmdCheckEmail.Parameters.AddWithValue("@email", email);
                    int emailCount = Convert.ToInt32(cmdCheckEmail.ExecuteScalar() ?? 0);
                    if (emailCount > 0)
                    {
                        MessageBox.Show("Podany email już istnieje w bazie lekarzy.", "Duplikat email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                using (var cmdCheckPhone = new SqlCommand("SELECT COUNT(1) FROM dbo.lekarze WHERE Phone = @phone", conn))
                {
                    cmdCheckPhone.Parameters.AddWithValue("@phone", telefon);
                    int phoneCount = Convert.ToInt32(cmdCheckPhone.ExecuteScalar() ?? 0);
                    if (phoneCount > 0)
                    {
                        MessageBox.Show("Podany numer telefonu już istnieje w bazie lekarzy.", "Duplikat telefonu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                const string sql = @"
INSERT INTO dbo.lekarze (FirstName, LastName, Email, Specialization, Phone, Password, LicenseNumber)
VALUES (@imie, @nazwisko, @email, @specjalizacja, @telefon, @password, @license)";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@imie", imie);
                cmd.Parameters.AddWithValue("@nazwisko", nazwisko);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@specjalizacja", specjalizacja);
                cmd.Parameters.AddWithValue("@telefon", telefon);

                var p = cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar, 256);
                p.Value = haslo;

                cmd.Parameters.AddWithValue("@license", numerLicencji);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Lekarz został dodany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                }
                else
                {
                    MessageBox.Show("Nie udało się dodać lekarza.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd połączenia / zapytania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void powrót_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }
    }
}
