using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hello world.");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int idadeJoao = 10;
			int idadeMaria = 25;
			int idadeAlessandro = 26;
			double media = (idadeJoao + idadeMaria + idadeAlessandro) / 3.0;

			MessageBox.Show("A média é : " + media);
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//int pi = 3.14; // Não compila
			MessageBox.Show("Não compila.");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			double pi = 3.14;
			int piQuebrado = (int) pi;
			MessageBox.Show("piQuebrado é : " + piQuebrado);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int a = 2;
			int b = -8;
			int c = 5;

			double delta;
			double a1;
			double a2;
			delta = b * b - 4 * a * c;
			a1 = (-b + Math.Sqrt(delta)) / (2 * a);
			a2 = (-b - Math.Sqrt(delta)) / (2 * a);

			MessageBox.Show("a1: " + a1);
			MessageBox.Show("a2: " + a2);
		}
	}
}
