using System.Data;
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
using System.Windows.Forms.Design;

namespace Przychodnia
{

    public partial class Form4 : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";

        public Form4()
        {
            InitializeComponent();

            // upewnij się, że kontrolki są ukryte po uruchomieniu programu
            if (dgv1 != null) dgv1.Visible = false;
            if (button6 != null) button6.Visible = false;
            if (button7 != null) button7.Visible = false;
            if (button8 != null) button8.Visible = false;
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
            // Ukryj elementy użytkowników przy przejściu do "Zarządzanie Lekarzami"
            var toHide = new Control[] { dgv1, button6, button7, button8 };
            foreach (var c in toHide)
            {
                if (c != null) c.Visible = false;
            }

            // Jeśli masz panele do zarządzania lekarzami/edycji, pokaż je tutaj
            var panelList = this.Controls.Find("panelList", true).FirstOrDefault();
            var panelEdit = this.Controls.Find("panelEdit", true).FirstOrDefault();

            if (panelList != null && panelEdit != null)
            {
                panelList.Visible = false;
                panelEdit.Visible = true;
            }
            else
            {
                // fallback: pokaż przyciski/ kontrolki związane z lekarzami (dostosuj nazwy)
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
            // Pokaż elementy związane z zarządzaniem użytkownikami
            if (dgv1 != null) dgv1.Visible = true;
            if (button6 != null) button6.Visible = true;
            if (button7 != null) button7.Visible = true;
            if (button8 != null) button8.Visible = true;

            // automatycznie pobierz dane po pokazaniu
            if (button6 != null) button6.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var toHide = new Control[] { dgv1, button6, button7, button8 };
            foreach (var c in toHide)
            {
                if (c != null) c.Visible = false;
            }

            // Jeśli masz panele do zarządzania lekarzami/edycji, pokaż je tutaj
            var panelList = this.Controls.Find("panelList", true).FirstOrDefault();
            var panelEdit = this.Controls.Find("panelEdit", true).FirstOrDefault();

            if (panelList != null && panelEdit != null)
            {
                panelList.Visible = false;
                panelEdit.Visible = true;
            }
            else
            {
                // fallback: pokaż przyciski/ kontrolki związane z lekarzami (dostosuj nazwy)
                string[] showNames = { "textBoxName", "buttonSave", "buttonCancel" };
                foreach (var name in showNames)
                {
                    var ctrl = this.Controls.Find(name, true).FirstOrDefault();
                    if (ctrl != null) ctrl.Visible = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var toHide = new Control[] { dgv1, button6, button7, button8 };
            foreach (var c in toHide)
            {
                if (c != null) c.Visible = false;
            }

            // Jeśli masz panele do zarządzania lekarzami/edycji, pokaż je tutaj
            var panelList = this.Controls.Find("panelList", true).FirstOrDefault();
            var panelEdit = this.Controls.Find("panelEdit", true).FirstOrDefault();

            if (panelList != null && panelEdit != null)
            {
                panelList.Visible = false;
                panelEdit.Visible = true;
            }
            else
            {
                // fallback: pokaż przyciski/ kontrolki związane z lekarzami (dostosuj nazwy)
                string[] showNames = { "textBoxName", "buttonSave", "buttonCancel" };
                foreach (var name in showNames)
                {
                    var ctrl = this.Controls.Find(name, true).FirstOrDefault();
                    if (ctrl != null) ctrl.Visible = true;
                }
            }
        }
    }
}