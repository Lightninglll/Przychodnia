namespace Przychodnia
{
	public partial class Form1 : Form
	{
        public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}


		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Log_lekarz f2 = new Log_lekarz();
			f2.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Log_urzy f3 = new Log_urzy();
			f3.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form4 f4 = new Form4();
			f4.Show();
			this.Hide();
		}
	}
}
