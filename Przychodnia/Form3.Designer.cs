namespace Przychodnia
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panelMenu = new Panel();
			button4 = new Button();
			button3 = new Button();
			button1 = new Button();
			panelLogo = new Panel();
			button5 = new Button();
			label1 = new Label();
			panelMenu.SuspendLayout();
			panelLogo.SuspendLayout();
			SuspendLayout();
			// 
			// panelMenu
			// 
			panelMenu.BackColor = Color.FromArgb(51, 51, 76);
			panelMenu.Controls.Add(button4);
			panelMenu.Controls.Add(button3);
			panelMenu.Controls.Add(button1);
			panelMenu.Controls.Add(panelLogo);
			panelMenu.Dock = DockStyle.Left;
			panelMenu.Location = new Point(0, 0);
			panelMenu.Name = "panelMenu";
			panelMenu.Size = new Size(220, 1041);
			panelMenu.TabIndex = 0;
			panelMenu.Paint += panel1_Paint;
			// 
			// button4
			// 
			button4.Dock = DockStyle.Top;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.ForeColor = Color.Gainsboro;
			button4.Location = new Point(0, 200);
			button4.Name = "button4";
			button4.Size = new Size(220, 60);
			button4.TabIndex = 5;
			button4.Text = "Dokumentacja medyczna";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.Dock = DockStyle.Top;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.ForeColor = Color.Gainsboro;
			button3.Location = new Point(0, 140);
			button3.Name = "button3";
			button3.Size = new Size(220, 60);
			button3.TabIndex = 4;
			button3.Text = "Historia Wizyt";
			button3.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Top;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = Color.Gainsboro;
			button1.Location = new Point(0, 80);
			button1.Name = "button1";
			button1.Size = new Size(220, 60);
			button1.TabIndex = 2;
			button1.Text = "Rezerwacja Wizyty";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// panelLogo
			// 
			panelLogo.BackColor = Color.FromArgb(39, 39, 58);
			panelLogo.Controls.Add(button5);
			panelLogo.Dock = DockStyle.Top;
			panelLogo.Location = new Point(0, 0);
			panelLogo.Name = "panelLogo";
			panelLogo.Size = new Size(220, 80);
			panelLogo.TabIndex = 1;
			// 
			// button5
			// 
			button5.Font = new Font("Segoe UI", 13F);
			button5.Location = new Point(57, 23);
			button5.Name = "button5";
			button5.Size = new Size(107, 34);
			button5.TabIndex = 9;
			button5.Text = "Powrót";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(1580, 65);
			label1.Name = "label1";
			label1.Size = new Size(131, 15);
			label1.TabIndex = 1;
			label1.Text = "Imie Naziwsko Pacjenta";
			label1.Click += label1_Click;
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			AutoSize = true;
			ClientSize = new Size(1904, 1041);
			Controls.Add(label1);
			Controls.Add(panelMenu);
			Name = "Form3";
			Text = "Panel Pacjenta";
			Load += Form3_Load;
			panelMenu.ResumeLayout(false);
			panelLogo.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panelMenu;
        private Panel panelLogo;
        private Button button1;
        private Button button4;
        private Button button3;
        private Label label1;
		private Button button5;
	}
}