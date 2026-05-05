namespace Przychodnia
{
    partial class Form4
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
            Zalog = new Label();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelLogo = new Panel();
            button5 = new Button();
            dgv1 = new DataGridView();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            labelId = new Label();
            txt_id = new TextBox();
            btnPotwierdz = new Button();
            dgv2 = new DataGridView();
            pobierz_lekarzy = new Button();
            Dodaj_lekarza = new Button();
            Usun_lekarza = new Button();
            potwierdz_lek = new Button();
            txt_lekarz_id = new TextBox();
            id_lekarza = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(Zalog);
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
            // 
            // Zalog
            // 
            Zalog.AutoSize = true;
            Zalog.ForeColor = SystemColors.Control;
            Zalog.Location = new Point(68, 964);
            Zalog.Name = "Zalog";
            Zalog.Size = new Size(38, 15);
            Zalog.TabIndex = 7;
            Zalog.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(55, 938);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 6;
            label1.Text = "Zalogowany jako";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Gainsboro;
            button4.Location = new Point(0, 260);
            button4.Name = "button4";
            button4.Size = new Size(220, 60);
            button4.TabIndex = 5;
            button4.Text = "Zarządzanie specjalizacjami";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            button3.Text = "Zarządzanie wizytami";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            button2.Text = "Zarządzanie Użytkownikami";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            button1.Text = "Zarządzanie Lekarzami";
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
            button5.Location = new Point(55, 24);
            button5.Name = "button5";
            button5.Size = new Size(107, 34);
            button5.TabIndex = 8;
            button5.Text = "Powrót";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(472, 231);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(1150, 650);
            dgv1.TabIndex = 2;
            dgv1.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(974, 127);
            button6.Name = "button6";
            button6.Size = new Size(130, 40);
            button6.TabIndex = 3;
            button6.Text = "Pobierz Użytkowników";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(838, 127);
            button7.Name = "button7";
            button7.Size = new Size(130, 40);
            button7.TabIndex = 4;
            button7.Text = "Dodaj Użytkownika";
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(1110, 127);
            button8.Name = "button8";
            button8.Size = new Size(130, 40);
            button8.TabIndex = 5;
            button8.Text = "Usuń Użytkownika";
            button8.UseVisualStyleBackColor = true;
            button8.Visible = false;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(1246, 119);
            labelId.Name = "labelId";
            labelId.Size = new Size(90, 15);
            labelId.TabIndex = 6;
            labelId.Text = " ID użytkownika";
            labelId.Visible = false;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(1246, 137);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 7;
            txt_id.Visible = false;
            // 
            // btnPotwierdz
            // 
            btnPotwierdz.Location = new Point(1352, 137);
            btnPotwierdz.Name = "btnPotwierdz";
            btnPotwierdz.Size = new Size(100, 23);
            btnPotwierdz.TabIndex = 8;
            btnPotwierdz.Text = "Potwierdź";
            btnPotwierdz.UseVisualStyleBackColor = true;
            btnPotwierdz.Visible = false;
            btnPotwierdz.Click += btnPotwierdz_Click;
            // 
            // dgv2
            // 
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv2.Location = new Point(472, 231);
            dgv2.Name = "dgv2";
            dgv2.Size = new Size(1150, 650);
            dgv2.TabIndex = 9;
            dgv2.Visible = false;
            // 
            // pobierz_lekarzy
            // 
            pobierz_lekarzy.Location = new Point(974, 127);
            pobierz_lekarzy.Name = "pobierz_lekarzy";
            pobierz_lekarzy.Size = new Size(130, 40);
            pobierz_lekarzy.TabIndex = 10;
            pobierz_lekarzy.Text = "Pobierz Lekarzy";
            pobierz_lekarzy.UseVisualStyleBackColor = true;
            pobierz_lekarzy.Visible = false;
            pobierz_lekarzy.Click += pobierz_lekarzy_Click;
            // 
            // Dodaj_lekarza
            // 
            Dodaj_lekarza.Location = new Point(838, 128);
            Dodaj_lekarza.Name = "Dodaj_lekarza";
            Dodaj_lekarza.Size = new Size(130, 40);
            Dodaj_lekarza.TabIndex = 11;
            Dodaj_lekarza.Text = "Dodaj Lekarza";
            Dodaj_lekarza.UseVisualStyleBackColor = true;
            Dodaj_lekarza.Visible = false;
            Dodaj_lekarza.Click += Dodaj_lekarza_Click_1;
            // 
            // Usun_lekarza
            // 
            Usun_lekarza.Location = new Point(1110, 128);
            Usun_lekarza.Name = "Usun_lekarza";
            Usun_lekarza.Size = new Size(130, 40);
            Usun_lekarza.TabIndex = 12;
            Usun_lekarza.Text = "Usuń Lekarza";
            Usun_lekarza.UseVisualStyleBackColor = true;
            Usun_lekarza.Visible = false;
            // 
            // potwierdz_lek
            // 
            potwierdz_lek.Location = new Point(1352, 137);
            potwierdz_lek.Name = "potwierdz_lek";
            potwierdz_lek.Size = new Size(100, 23);
            potwierdz_lek.TabIndex = 15;
            potwierdz_lek.Text = "Potwierdź";
            potwierdz_lek.UseVisualStyleBackColor = true;
            potwierdz_lek.Visible = false;
            potwierdz_lek.Click += potwierdz_lek_Click_1;
            // 
            // txt_lekarz_id
            // 
            txt_lekarz_id.Location = new Point(1246, 137);
            txt_lekarz_id.Name = "txt_lekarz_id";
            txt_lekarz_id.Size = new Size(100, 23);
            txt_lekarz_id.TabIndex = 14;
            txt_lekarz_id.Visible = false;
            // 
            // id_lekarza
            // 
            id_lekarza.AutoSize = true;
            id_lekarza.Location = new Point(1246, 119);
            id_lekarza.Name = "id_lekarza";
            id_lekarza.Size = new Size(90, 15);
            id_lekarza.TabIndex = 13;
            id_lekarza.Text = " ID użytkownika";
            id_lekarza.Visible = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1904, 1041);
            Controls.Add(potwierdz_lek);
            Controls.Add(txt_lekarz_id);
            Controls.Add(id_lekarza);
            Controls.Add(Usun_lekarza);
            Controls.Add(Dodaj_lekarza);
            Controls.Add(pobierz_lekarzy);
            Controls.Add(dgv2);
            Controls.Add(btnPotwierdz);
            Controls.Add(txt_id);
            Controls.Add(labelId);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(dgv1);
            Controls.Add(panelMenu);
            Name = "Form4";
            Text = "Panel Administratora";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
		private Button button5;
        private DataGridView dgv1;
        private Button button6;
        private Button button7;
        private Button button8;

        // nowe pola
        private Label labelId;
        private TextBox txt_id;
        private Button btnPotwierdz;
        private DataGridView dgv2;
        private Button pobierz_lekarzy;
        private Button Dodaj_lekarza;
        private Button Usun_lekarza;
        private Button potwierdz_lek;
        private TextBox txt_lekarz_id;
        private Label id_lekarza;
        private Label Zalog;
        private Label label1;
    }
}