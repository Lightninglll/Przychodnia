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
    public partial class Log_lekarz : Form
    {
        public Log_lekarz()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            var email = txt_login.Text.Trim();
            var haslo = txt_haslo.Text;

            // Pobieramy Id, Imię i Nazwisko lekarza
            const string sql = "SELECT id_lekarz, FirstName, LastName FROM dbo.lekarze WHERE email = @email AND Password = @haslo";

            try
            {
                using var conn = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False");
                using var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@haslo", haslo);
                conn.Open();

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int doctorId = 0;
                    try
                    {
                        doctorId = reader.IsDBNull(0) ? 0 : Convert.ToInt32(reader.GetValue(0));
                    }
                    catch
                    {
                        doctorId = 0;
                    }

                    var firstName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    var lastName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    var displayName = $"{firstName} {lastName}".Trim();

                    // Przekazujemy id lekarza do Form2, aby filtrować wizyty
                    Form2 f2 = new Form2(displayName, doctorId);
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy email lub hasło");
                    txt_login.Clear();
                    txt_haslo.Clear();
                    txt_login.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_login.Clear();
            txt_haslo.Clear();

            txt_login.Focus();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
