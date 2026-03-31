namespace Przychodnia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(776, 62);
            label1.Name = "label1";
            label1.Size = new Size(239, 46);
            label1.TabIndex = 0;
            label1.Text = "Strona Główna";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(5, 28);
            label3.Name = "label3";
            label3.Size = new Size(233, 25);
            label3.TabIndex = 2;
            label3.Text = "Numer tel: +48 999999999";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(5, 69);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 3;
            label4.Text = "Adres: zzzxxxyyy 5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(5, 110);
            label5.Name = "label5";
            label5.Size = new Size(284, 25);
            label5.TabIndex = 4;
            label5.Text = "E-mail: przychodnia@gmail.com";
            label5.Click += label5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(1597, 881);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 148);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kontakt";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 14F);
            groupBox2.Location = new Point(1597, 580);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 296);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Godziny Otwarcia";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 243);
            label11.Name = "label11";
            label11.Size = new Size(138, 25);
            label11.TabIndex = 7;
            label11.Text = "Niedziela: 8-16";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 38);
            label10.Name = "label10";
            label10.Size = new Size(165, 25);
            label10.TabIndex = 7;
            label10.Text = "Poniedziałek: 6-22";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 72);
            label9.Name = "label9";
            label9.Size = new Size(120, 25);
            label9.TabIndex = 7;
            label9.Text = "Wtorek: 6-22";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 106);
            label8.Name = "label8";
            label8.Size = new Size(108, 25);
            label8.TabIndex = 7;
            label8.Text = "Środa: 6-22";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 140);
            label7.Name = "label7";
            label7.Size = new Size(136, 25);
            label7.TabIndex = 7;
            label7.Text = "Czwartek: 6-22";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 209);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 1;
            label6.Text = "Sobota: 8-20";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 174);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 0;
            label2.Text = "Piątek: 6-22";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(1687, 62);
            button1.Name = "button1";
            button1.Size = new Size(107, 34);
            button1.TabIndex = 7;
            button1.Text = "Lekarz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F);
            button2.Location = new Point(1687, 102);
            button2.Name = "button2";
            button2.Size = new Size(107, 34);
            button2.TabIndex = 8;
            button2.Text = "Pacjent";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13F);
            button3.Location = new Point(1687, 142);
            button3.Name = "button3";
            button3.Size = new Size(107, 34);
            button3.TabIndex = 9;
            button3.Text = "Admin";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1904, 1041);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Przychodnia";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private Label label11;
        private Button button1;
		private Button button2;
		private Button button3;
	}
}
