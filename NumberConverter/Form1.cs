using NumberConversion;
using System.Security.Cryptography.X509Certificates;

namespace NumberConverter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBox1.Text= string.Empty;
			textBox2.Text= string.Empty;
			textBox3.Text= string.Empty;
			textBox4.Text= string.Empty;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string number = textBox1.Text;
			int currentSystem = int.Parse(textBox2.Text);
			int neededSystem = int.Parse(textBox3.Text);

			string s = NumberConverterService.Convert(number, currentSystem, neededSystem);
			textBox4.Text = s;

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}
	}
}