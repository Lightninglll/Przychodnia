namespace Przychodnia
{
    partial class Form2
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
            label = new Label();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelLogo = new Panel();
            button5 = new Button();
            dgvWizyty = new DataGridView();
            Pobierz = new Button();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWizyty).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(label);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 1041);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // label
            // 
            label.AutoSize = true;
            label.ForeColor = SystemColors.Control;
            label.Location = new Point(55, 951);
            label.Name = "label";
            label.Size = new Size(101, 15);
            label.TabIndex = 1;
            label.Text = "Zalogowano jako:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(55, 977);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "Zalogowano jako:";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Gainsboro;
            button4.Location = new Point(0, 260);
            button4.Name = "button4";
            button4.Size = new Size(220, 60);
            button4.TabIndex = 5;
            button4.Text = "Wizyta";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(0, 200);
            button3.Name = "button3";
            button3.Size = new Size(220, 60);
            button3.TabIndex = 4;
            button3.Text = "Historia Wizyt";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(0, 140);
            button2.Name = "button2";
            button2.Size = new Size(220, 60);
            button2.TabIndex = 3;
            button2.Text = "Lista Planowanych wizyt";
            button2.UseVisualStyleBackColor = true;
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
            button1.Text = "Harmonogram pracy";
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
            button5.AutoSize = true;
            button5.Font = new Font("Segoe UI", 13F);
            button5.Location = new Point(55, 24);
            button5.Name = "button5";
            button5.Size = new Size(107, 35);
            button5.TabIndex = 8;
            button5.Text = "Powrót";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dgvWizyty
            // 
            dgvWizyty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWizyty.Location = new Point(592, 200);
            dgvWizyty.Name = "dgvWizyty";
            dgvWizyty.Size = new Size(989, 548);
            dgvWizyty.TabIndex = 1;
            // 
            // Pobierz
            // 
            Pobierz.Location = new Point(1047, 124);
            Pobierz.Name = "Pobierz";
            Pobierz.Size = new Size(113, 39);
            Pobierz.TabIndex = 2;
            Pobierz.Text = "Pobierz Dane";
            Pobierz.UseVisualStyleBackColor = true;
            Pobierz.Click += Pobierz_Click;
            // 
            // btnEdytujOpis
            // 
            btnEdytujOpis = new Button();
            btnEdytujOpis.Location = new Point(1180, 124);
            btnEdytujOpis.Name = "btnEdytujOpis";
            btnEdytujOpis.Size = new Size(120, 39);
            btnEdytujOpis.TabIndex = 3;
            btnEdytujOpis.Text = "Edytuj opis";
            btnEdytujOpis.UseVisualStyleBackColor = true;
            btnEdytujOpis.Click += btnEdytujOpis_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Pobierz);

            Controls.Add(dgvWizyty);
            Controls.Add(panelMenu);
            Name = "Form2";
            Text = "Panel Lekarza";
            Load += Form2_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWizyty).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
		private Button button5;
        private Label label;
        private DataGridView dgvWizyty;
        private Button Pobierz;
        private Button btnEdytujOpis;
    }
}