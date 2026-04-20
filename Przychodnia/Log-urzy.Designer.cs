namespace Przychodnia
{
    partial class Log_urzy
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_login = new TextBox();
            txt_haslo = new TextBox();
            button_login = new Button();
            button_clear = new Button();
            button_exit = new Button();
            Rejestracja = new LinkLabel();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 122);
            label2.Name = "label2";
            label2.Size = new Size(60, 24);
            label2.TabIndex = 1;
            label2.Text = "Witaj";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 207);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "email/id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 273);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Hasło";
            // 
            // txt_login
            // 
            txt_login.Location = new Point(123, 199);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(158, 23);
            txt_login.TabIndex = 4;
            // 
            // txt_haslo
            // 
            txt_haslo.Location = new Point(123, 265);
            txt_haslo.Name = "txt_haslo";
            txt_haslo.Size = new Size(158, 23);
            txt_haslo.TabIndex = 5;
            // 
            // button_login
            // 
            button_login.Location = new Point(199, 325);
            button_login.Name = "button_login";
            button_login.Size = new Size(75, 23);
            button_login.TabIndex = 6;
            button_login.Text = "Zaloguj";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(109, 325);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(75, 23);
            button_clear.TabIndex = 7;
            button_clear.Text = "Wyczyść";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(227, 553);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(75, 23);
            button_exit.TabIndex = 8;
            button_exit.Text = "Wyjdź";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // Rejestracja
            // 
            Rejestracja.AutoSize = true;
            Rejestracja.Location = new Point(221, 33);
            Rejestracja.Name = "Rejestracja";
            Rejestracja.Size = new Size(93, 15);
            Rejestracja.TabIndex = 9;
            Rejestracja.TabStop = true;
            Rejestracja.Text = "Nie masz konta?";
            Rejestracja.LinkClicked += Rejestracja_LinkClicked;
            // 
            // Log_urzy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 610);
            Controls.Add(Rejestracja);
            Controls.Add(button_exit);
            Controls.Add(button_clear);
            Controls.Add(button_login);
            Controls.Add(txt_haslo);
            Controls.Add(txt_login);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Log_urzy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log_urzy";
            Load += Log_urzy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_login;
        private TextBox txt_haslo;
        private Button button_login;
        private Button button_clear;
        private Button button_exit;
        private LinkLabel Rejestracja;
    }
}