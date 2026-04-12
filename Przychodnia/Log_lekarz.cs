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

            const string sql = "SELECT COUNT(1) FROM dbo.lekarze WHERE email = @email AND Password = @haslo";

            try
            {
                using var conn = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False");
                using var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@haslo", haslo); // na dłuższą metę użyj hashów haseł
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);

                if (count > 0)
                {
                    new Form3().Show();
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
                MessageBox.Show(ex.Message); // pokaże faktyczny błąd SQL
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
   
