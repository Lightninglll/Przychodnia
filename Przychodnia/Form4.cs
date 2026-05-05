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

        public Form4()
        {
            InitializeComponent();

            if (dgv1 != null) dgv1.Visible = false;
            if (button6 != null) button6.Visible = false;
            if (button7 != null) button7.Visible = false;
            if (button8 != null) button8.Visible = false;

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
            // Ukryj elementy związane z zarządzaniem użytkownikami oraz ewentualne pola usuwania
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

            if (labelId != null) labelId.Visible = false;
            if (txt_id != null) txt_id.Visible = false;
            if (btnPotwierdz != null) btnPotwierdz.Visible = false;

            if (button6 != null) button6.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
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