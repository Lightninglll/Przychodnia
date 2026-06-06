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
    public partial class Form2 : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";

        // id aktualnie zalogowanego lekarza (0 = brak)
        private int loggedDoctorId = 0;

        public Form2()
        {
            InitializeComponent();
            AttachHandlers();
        }

        // przeciążony konstruktor przyjmujący nazwę i id lekarza
        public Form2(string displayName, int doctorId) : this()
        {
            loggedDoctorId = doctorId;
            if (!string.IsNullOrEmpty(displayName) && label1 != null)
            {
                label1.Text = displayName;
            }
        }

        public Form2(string displayName)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(displayName) && label1 != null)
            {
                label1.Text = displayName;
            }
            AttachHandlers();
        }

        private void AttachHandlers()
        {
            if (dgvWizyty != null)
            {
                // upewnij się, że nie podpinamy wielokrotnie
                dgvWizyty.CellDoubleClick -= dgvWizyty_CellDoubleClick;
                dgvWizyty.CellDoubleClick += dgvWizyty_CellDoubleClick;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Pobierz_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sqlCon = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
                {
                    sqlCon.Open();

                    // filtr: tylko przyszłe daty (Data_Wizyty >= dziś)
                    // oraz jeśli znamy id lekarza (loggedDoctorId > 0) to filtrujemy po nim
                    string sql;
                    if (loggedDoctorId > 0)
                    {
                        sql = @"SELECT w.*, ISNULL(l.FirstName + ' ' + l.LastName, '') AS Lekarz
                                FROM dbo.wizyty w
                                LEFT JOIN dbo.lekarze l ON w.id_lekarz = l.id_lekarz
                                WHERE w.id_lekarz = @id_lekarz
                                  AND w.Data_Wizyty >= CAST(GETDATE() AS DATE)
                                ORDER BY w.Data_Wizyty";
                        using var da = new Microsoft.Data.SqlClient.SqlDataAdapter(sql, sqlCon);
                        da.SelectCommand.Parameters.AddWithValue("@id_lekarz", loggedDoctorId);
                        DataTable dtbl = new DataTable();
                        da.Fill(dtbl);
                        dgvWizyty.DataSource = dtbl;
                        // jeśli był widoczny dgvHistoria, ukryj aby nie mieszać widoków
                        if (dgvHistoria != null) dgvHistoria.Visible = false;
                    }
                    else
                    {
                        // jeśli nie mamy id lekarza, pokaż wszystkie przyszłe wizyty
                        sql = @"SELECT w.*, ISNULL(l.FirstName + ' ' + l.LastName, '') AS Lekarz
                                FROM dbo.wizyty w
                                LEFT JOIN dbo.lekarze l ON w.id_lekarz = l.id_lekarz
                                WHERE w.Data_Wizyty >= CAST(GETDATE() AS DATE)
                                ORDER BY ISNULL(l.FirstName + ' ' + l.LastName, ''), w.Data_Wizyty";
                        using var da = new Microsoft.Data.SqlClient.SqlDataAdapter(sql, sqlCon);
                        DataTable dtbl = new DataTable();
                        da.Fill(dtbl);
                        dgvWizyty.DataSource = dtbl;
                        if (dgvHistoria != null) dgvHistoria.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd pobierania wizyt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // handler dla przycisku "Historia Wizyt" - pokazuje przycisk pobierania historii i grid
        private void button3_Click(object sender, EventArgs e)
        {
            if (btnDane != null) btnDane.Visible = true;
            if (dgvHistoria != null) dgvHistoria.Visible = true;
            // ukryj bieżące wizyty, żeby nie nachodziły
            if (dgvWizyty != null) dgvWizyty.Visible = false;
        }

        // pobiera i pokazuje w dgvHistoria historię (wizyty przeszłe) przypisaną do zalogowanego lekarza
        private void btnDane_Click(object sender, EventArgs e)
        {
            if (loggedDoctorId == 0)
            {
                MessageBox.Show("Brak identyfikatora zalogowanego lekarza.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var sqlCon = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                sqlCon.Open();

                string sql = @"
SELECT w.*, ISNULL(l.FirstName + ' ' + l.LastName, '') AS Lekarz
FROM dbo.wizyty w
LEFT JOIN dbo.lekarze l ON w.id_lekarz = l.id_lekarz
WHERE w.id_lekarz = @id_lekarz
  AND w.Data_Wizyty < CAST(GETDATE() AS DATE)
ORDER BY w.Data_Wizyty DESC";

                using var da = new Microsoft.Data.SqlClient.SqlDataAdapter(sql, sqlCon);
                da.SelectCommand.Parameters.AddWithValue("@id_lekarz", loggedDoctorId);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);

                if (dgvHistoria != null)
                {
                    dgvHistoria.DataSource = dtbl;
                    dgvHistoria.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd pobierania historii", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdytujOpis_Click(object sender, EventArgs e)
        {
            // użyj obecnego zaznaczenia
            if (dgvWizyty == null || dgvWizyty.CurrentRow == null)
            {
                MessageBox.Show("Wybierz wiersz wizyty, który chcesz edytować.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dgvWizyty.CurrentRow.Index;
            // uruchom ten sam handler jak przy dwukliku
            var args = new DataGridViewCellEventArgs(0, rowIndex);
            dgvWizyty_CellDoubleClick(dgvWizyty, args);
        }

        private void dgvWizyty_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var grid = dgvWizyty;
            if (grid == null) return;

            var row = grid.Rows[e.RowIndex];

            // spróbuj znaleźć kolumnę z id w ustalonej liście
            string[] idCandidates = new[] { "Id", "id", "Id_wizyty", "id_wizyty", "ID" };
            string idColumn = null;
            foreach (var c in idCandidates)
            {
                if (grid.Columns.Contains(c)) { idColumn = c; break; }
            }
            if (idColumn == null)
            {
                // fallback: pierwsza kolumna
                if (grid.Columns.Count > 0) idColumn = grid.Columns[0].Name;
            }

            var idValue = idColumn != null ? row.Cells[idColumn].Value : row.Cells[0].Value;
            if (idValue == null)
            {
                MessageBox.Show("Nie można odczytać ID wybranej wizyty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // znajdź istniejący opis (kolumny: Opis/opis)
            string opis = string.Empty;
            if (grid.Columns.Contains("Opis")) opis = row.Cells["Opis"].Value?.ToString() ?? string.Empty;
            else if (grid.Columns.Contains("opis")) opis = row.Cells["opis"].Value?.ToString() ?? string.Empty;

            // pokaż modal do edycji opisu
            using var f = new OpisForm(opis);
            var dr = f.ShowDialog(this);
            if (dr != DialogResult.OK) return;

            var newOpis = f.Opis ?? string.Empty;

            // zapisz do bazy
            try
            {
                using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                conn.Open();

                // upewnij się, że istnieje kolumna 'Opis' (tworzymy jeśli brak)
                const string checkSql = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'wizyty' AND COLUMN_NAME = 'Opis'";
                using (var chkCmd = new Microsoft.Data.SqlClient.SqlCommand(checkSql, conn))
                {
                    var exists = (int)chkCmd.ExecuteScalar();
                    if (exists == 0)
                    {
                        using var alter = new Microsoft.Data.SqlClient.SqlCommand("ALTER TABLE dbo.wizyty ADD Opis NVARCHAR(MAX) NULL", conn);
                        alter.ExecuteNonQuery();
                    }
                }

                // zbuduj zapytanie UPDATE wykorzystując znalezioną nazwę kolumny id
                string idColSafe = idColumn ?? grid.Columns[0].Name;
                // walidacja - upewnij się, że nazwa kolumny istnieje w tabeli danych (z dgv)
                if (!grid.Columns.Contains(idColSafe)) idColSafe = grid.Columns[0].Name;

                string updateSql = $"UPDATE dbo.wizyty SET Opis = @opis WHERE [{idColSafe}] = @id";
                using var upd = new Microsoft.Data.SqlClient.SqlCommand(updateSql, conn);
                upd.Parameters.AddWithValue("@opis", newOpis);
                upd.Parameters.AddWithValue("@id", idValue);
                int affected = upd.ExecuteNonQuery();

                if (affected > 0)
                {
                    MessageBox.Show("Opis zapisany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // odśwież widok
                    Pobierz.PerformClick();
                }
                else
                {
                    MessageBox.Show("Nie znaleziono rekordu do aktualizacji.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
