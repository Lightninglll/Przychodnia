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
            var toHide = new Control[] { dgv1, button6, button7, button8, labelId, txt_id, btnPotwierdz };
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv1 != null) dgv1.Visible = true;
            if (button6 != null) button6.Visible = true;
            if (button7 != null) button7.Visible = true;
            if (button8 != null) button8.Visible = true;

            if (button6 != null) button6.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv1 != null) dgv1.Visible = false;
            if (button6 != null) button6.Visible = false;
            if (button7 != null) button7.Visible = false;
            if (button8 != null) button8.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgv1 != null) dgv1.Visible = false;
            if (button6 != null) button6.Visible = false;
            if (button7 != null) button7.Visible = false;
            if (button8 != null) button8.Visible = false;

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

            var confirm = MessageBox.Show($"Potwierdzasz operację dla ID = {id}?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                MessageBox.Show($"Potwierdzono operację dla ID = {id}.", "Potwierdzone", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (labelId != null) labelId.Visible = false;
                if (txt_id != null) txt_id.Visible = false;
                if (btnPotwierdz != null) btnPotwierdz.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dod_uzy f1 = new Dod_uzy();
            f1.Show();
            this.Close();
        }
    }
}