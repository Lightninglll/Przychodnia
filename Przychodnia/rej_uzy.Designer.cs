namespace Przychodnia
{
    partial class rej_uzy
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            rej = new Button();
            clear = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(39, 26);
            label1.Name = "label1";
            label1.Size = new Size(253, 24);
            label1.TabIndex = 0;
            label1.Text = "Rejestracja Użytkownika";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(128, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(128, 195);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(164, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(128, 233);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(164, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(128, 271);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(164, 23);
            textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(128, 310);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(164, 23);
            textBox7.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 81);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 8;
            label2.Text = "Imie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 121);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "Nazwisko";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 160);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 10;
            label4.Text = "Data Urodzenia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 198);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 236);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 12;
            label6.Text = "Telefon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 274);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 13;
            label7.Text = "Hasło";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 313);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 14;
            label8.Text = "Powtórz Hasło";
            // 
            // rej
            // 
            rej.Location = new Point(217, 356);
            rej.Name = "rej";
            rej.Size = new Size(75, 23);
            rej.TabIndex = 15;
            rej.Text = "Rejestruj";
            rej.UseVisualStyleBackColor = true;
            rej.Click += rej_Click;
            // 
            // clear
            // 
            clear.Location = new Point(128, 356);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 16;
            clear.Text = "Wyczyść";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // back
            // 
            back.Location = new Point(217, 525);
            back.Name = "back";
            back.Size = new Size(75, 21);
            back.TabIndex = 17;
            back.Text = "Powrót";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // rej_uzy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 571);
            Controls.Add(back);
            Controls.Add(clear);
            Controls.Add(rej);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "rej_uzy";
            Text = "rej_uzy";
            Load += rej_uzy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button rej;
        private Button clear;
        private Button back;
    }
}