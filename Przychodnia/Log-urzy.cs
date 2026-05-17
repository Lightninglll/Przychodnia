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
    public partial class Log_urzy : Form
    {
        public Log_urzy()
        {
            InitializeComponent();
        }
        Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False");


        private void Log_urzy_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            var email = txt_login.Text.Trim();
            var haslo = txt_haslo.Text;

            // Pobieramy Id, imię, nazwisko oraz informację czy jest admin (CzyAdmin)
            const string sql = "SELECT id_uzytkownik, FirstName, LastName, CzyAdmin FROM dbo.urzytkownicy WHERE email = @email AND Password = @haslo";

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
                    int userId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    var firstName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    var lastName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    var displayName = $"{firstName} {lastName}".Trim();

                    bool isAdmin = false;
                    if (!reader.IsDBNull(3))
                    {
                        var value = reader.GetValue(3);
                        try
                        {
                            isAdmin = Convert.ToInt32(value) == 1;
                        }
                        catch
                        {
                            try { isAdmin = Convert.ToBoolean(value); } catch { isAdmin = false; }
                        }
                    }

                    if (isAdmin)
                    {
                        Form4 adminForm = new Form4(displayName);
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // przekazujemy również id użytkownika do Form3
                        Form3 f3 = new Form3(displayName, userId);
                        f3.Show();
                        this.Hide();
                    }
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

        private void Rejestracja_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rej_uzy f2 = new rej_uzy();
            f2.Show();
            this.Close();
        }
    }
}
