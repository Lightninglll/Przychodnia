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
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
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
            labelId.Location = new Point(1252, 119);
            labelId.Name = "labelId";
            labelId.Size = new Size(27, 15);
            labelId.TabIndex = 6;
            labelId.Text = " ID  ";
            labelId.Visible = false;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(1249, 137);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(30, 23);
            txt_id.TabIndex = 7;
            txt_id.Visible = false;
            // 
            // btnPotwierdz
            // 
            btnPotwierdz.Location = new Point(1285, 137);
            btnPotwierdz.Name = "btnPotwierdz";
            btnPotwierdz.Size = new Size(100, 23);
            btnPotwierdz.TabIndex = 8;
            btnPotwierdz.Text = "Potwierdź";
            btnPotwierdz.UseVisualStyleBackColor = true;
            btnPotwierdz.Visible = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1904, 1041);
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
    }
}