namespace Przychodnia
{
    partial class Dod_uzy
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
            txt_imie = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_nazwisko = new TextBox();
            label4 = new Label();
            txt_datauro = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            Dodaj_uz = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_imie
            // 
            txt_imie.Location = new Point(177, 59);
            txt_imie.Name = "txt_imie";
            txt_imie.Size = new Size(132, 23);
            txt_imie.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(247, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 24);
            label1.TabIndex = 1;
            label1.Text = "Dodawanie Użytkownika";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 62);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "imie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 110);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Nazwisko";
            // 
            // txt_nazwisko
            // 
            txt_nazwisko.Location = new Point(177, 107);
            txt_nazwisko.Name = "txt_nazwisko";
            txt_nazwisko.Size = new Size(132, 23);
            txt_nazwisko.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 168);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 6;
            label4.Text = "Data Urodzenia";
            // 
            // txt_datauro
            // 
            txt_datauro.Location = new Point(177, 165);
            txt_datauro.Name = "txt_datauro";
            txt_datauro.Size = new Size(132, 23);
            txt_datauro.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(388, 168);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 12;
            label5.Text = "Hasło";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(490, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 110);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 10;
            label6.Text = "Telefon";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(490, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(388, 62);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 8;
            label7.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(490, 59);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 23);
            textBox3.TabIndex = 7;
            // 
            // Dodaj_uz
            // 
            Dodaj_uz.Location = new Point(305, 308);
            Dodaj_uz.Name = "Dodaj_uz";
            Dodaj_uz.Size = new Size(119, 49);
            Dodaj_uz.TabIndex = 13;
            Dodaj_uz.Text = "Dodaj";
            Dodaj_uz.UseVisualStyleBackColor = true;
            Dodaj_uz.Click += Dodaj_uz_Click;
            // 
            // button1
            // 
            button1.Location = new Point(632, 371);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Dod_uzy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Dodaj_uz);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(txt_datauro);
            Controls.Add(label3);
            Controls.Add(txt_nazwisko);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_imie);
            Name = "Dod_uzy";
            Text = "Dod_uzy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_imie;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_nazwisko;
        private Label label4;
        private TextBox txt_datauro;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Button Dodaj_uz;
        private Button button1;
    }
}