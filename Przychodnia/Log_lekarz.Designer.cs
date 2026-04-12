namespace Przychodnia
{
    partial class Log_lekarz
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
            button_exit = new Button();
            button_clear = new Button();
            button_login = new Button();
            txt_haslo = new TextBox();
            txt_login = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button_exit
            // 
            button_exit.Location = new Point(210, 489);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(75, 23);
            button_exit.TabIndex = 16;
            button_exit.Text = "Wyjdź";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(92, 261);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(75, 23);
            button_clear.TabIndex = 15;
            button_clear.Text = "Wyczyść";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_login
            // 
            button_login.Location = new Point(182, 261);
            button_login.Name = "button_login";
            button_login.Size = new Size(75, 23);
            button_login.TabIndex = 14;
            button_login.Text = "Zaloguj";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // txt_haslo
            // 
            txt_haslo.Location = new Point(106, 201);
            txt_haslo.Name = "txt_haslo";
            txt_haslo.Size = new Size(158, 23);
            txt_haslo.TabIndex = 13;
            // 
            // txt_login
            // 
            txt_login.Location = new Point(106, 135);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(158, 23);
            txt_login.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 209);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 11;
            label4.Text = "Hasło";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 143);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 10;
            label3.Text = "email/id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 58);
            label2.Name = "label2";
            label2.Size = new Size(60, 24);
            label2.TabIndex = 9;
            label2.Text = "Witaj";
            // 
            // Log_lekarz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 571);
            Controls.Add(button_exit);
            Controls.Add(button_clear);
            Controls.Add(button_login);
            Controls.Add(txt_haslo);
            Controls.Add(txt_login);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Log_lekarz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log_lekarz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_exit;
        private Button button_clear;
        private Button button_login;
        private TextBox txt_haslo;
        private TextBox txt_login;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}