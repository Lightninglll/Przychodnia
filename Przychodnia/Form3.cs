using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

        public Form3(string displayName)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(displayName) && imienazwisko != null)
            {
                imienazwisko.Text = displayName;
            }
        }

		private void Form3_Load(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{

		}
	}
}
