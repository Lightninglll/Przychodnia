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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

        public Form2(string displayName)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(displayName) && label1 != null)
            {
                label1.Text = displayName;
            }
        }

		private void Form2_Load(object sender, EventArgs e)
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
	}
}
