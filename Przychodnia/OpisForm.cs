using System;
using System.Drawing;
using System.Windows.Forms;

namespace Przychodnia
{
	public class OpisForm : Form
	{
		private TextBox txtOpis;
		private Button btnOk;
		private Button btnCancel;

		public string Opis => txtOpis?.Text ?? string.Empty;

		public OpisForm(string initialOpis)
		{
			InitializeComponent();
			txtOpis.Text = initialOpis ?? string.Empty;
		}

		private void InitializeComponent()
		{
			this.Text = "Edytuj opis wizyty";
			this.Size = new Size(600, 400);
			this.StartPosition = FormStartPosition.CenterParent;

			txtOpis = new TextBox();
			txtOpis.Multiline = true;
			txtOpis.ScrollBars = ScrollBars.Vertical;
			txtOpis.Location = new Point(12, 12);
			txtOpis.Size = new Size(560, 300);

			btnOk = new Button();
			btnOk.Text = "Zapisz";
			btnOk.Location = new Point(392, 320);
			btnOk.Size = new Size(80, 30);
			btnOk.Click += (s, e) => { this.DialogResult = DialogResult.OK; this.Close(); };

			btnCancel = new Button();
			btnCancel.Text = "Anuluj";
			btnCancel.Location = new Point(492, 320);
			btnCancel.Size = new Size(80, 30);
			btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

			this.Controls.Add(txtOpis);
			this.Controls.Add(btnOk);
			this.Controls.Add(btnCancel);
		}
	}
}
