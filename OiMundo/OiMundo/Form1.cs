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
			int piQuebrado = (int)pi;
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

		private void button6_Click(object sender, EventArgs e)
		{
			double saldo = 100.0;
			double valorSaque = 10.0;
			if (saldo >= valorSaque)
			{
				saldo -= valorSaque;
				MessageBox.Show("Saque realizado com sucesso");
			}
			else
			{
				MessageBox.Show("Saldo insuficiente");
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			double saldo = 5.0;
			double valorSaque = 10.0;
			if (saldo >= valorSaque)
			{
				saldo -= valorSaque;
				MessageBox.Show("Saque realizado com sucesso");
			}
			else
			{
				MessageBox.Show("Saldo insuficiente");
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			double saldo = 500.0;
			if (saldo < 0.0)
			{
				MessageBox.Show("Você está no negativo");
			}
			else if (saldo < 1000000.0)
			{
				MessageBox.Show("Você é um bom cliente");
			}
			else
			{
				MessageBox.Show("Você é milionário");
			}

		}

		private void button9_Click(object sender, EventArgs e)
		{
			int idade = 17;
			bool brasileira = true;
			if (idade >= 16 && brasileira)
			{
				MessageBox.Show("Pode votar.");
			}
			else
			{
				MessageBox.Show("Não pode votar.");
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			double valorNotaFiscal;
			double imposto;
			valorNotaFiscal = 1500;
			if (valorNotaFiscal <= 1000.0)
			{
				imposto = valorNotaFiscal * 0.020;
			}
			else if (valorNotaFiscal > 1000.0 && valorNotaFiscal <= 3000.0)
			{
				imposto = valorNotaFiscal * 0.025;
			}
			else if (valorNotaFiscal > 3000 && valorNotaFiscal <= 7000)
			{
				imposto = valorNotaFiscal * 0.028;
			}
			else
			{
				imposto = valorNotaFiscal * 0.03;
			}
			MessageBox.Show("Imposto é: " + imposto);
		}

		private void button11_Click(object sender, EventArgs e)
		{
			int valor = 15;
			string mensagem = "";
			mensagem = valor > 10 ? "Maior que dez" : "Menor que dez";
			MessageBox.Show(mensagem);
		}

		private void button12_Click(object sender, EventArgs e)
		{
			int total = 2;
			for (int i = 0; i < 5; i += 1)
			{
				total = total * 2;
			}
			MessageBox.Show("O total é: " + total);
		}

		private void button13_Click(object sender, EventArgs e)
		{
			int soma = 0;
			for (int i = 1; i <= 100; i++)
			{
				soma += i;
			}
			MessageBox.Show("A soma dos números de 1 a 1000 é: " + soma);
		}

		private void button14_Click(object sender, EventArgs e)
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0)
				{
					MessageBox.Show(i + " é múltiplo de 3");
				}
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			int soma = 0;
			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 != 0)
				{
					soma += i;
				}
			}
			MessageBox.Show("O resultado é: " + soma);
		}

		private void button16_Click(object sender, EventArgs e)
		{
			for (int i = 0; i <= 30; i++)
			{
				if (i % 3 == 0 || i % 4 == 0)
				{
					MessageBox.Show(i + " é múltiplo de 3 ou 4");
				}
			}
		}

		private void button17_Click(object sender, EventArgs e)
		{
			int fatorial = 1;
			for(int n = 1; n<=10; n++)
			{
				MessageBox.Show("Fatorial de "+n+" é: " + fatorial);
				fatorial *= n + 1;
			}
		}

		private void button18_Click(object sender, EventArgs e)
		{
			int x = 1;
			int y = 1;
			int aux=x+y;
			MessageBox.Show(""+x);
			MessageBox.Show("" + y);
			while (aux<=100)
			{
				aux = x + y;
				x = y;
				y = aux;
				MessageBox.Show("" + aux);
			}
		}

		private void button19_Click(object sender, EventArgs e)
		{
			string tabela="";
			for (int i = 1; i < 7; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					tabela += i * j + " ";
				}
				tabela += "\n";
			}
			MessageBox.Show(tabela);
		}
	}
}
