using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
	public partial class Form1 : Form
	{
		Conta conta;
		Cliente titular;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			conta = new Conta();
			titular = new Cliente("Victor");
			conta.Numero = 1;
			conta.Titular = titular;
			textoTitular.Text = Convert.ToString(conta.Titular.Nome);
			textoNumero.Text = Convert.ToString(conta.Numero);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			conta.Deposita(Convert.ToDouble(textoValor.Text));
			AtualizaSaldo();
		}

		private void AtualizaSaldo()
		{
			textoSaldo.Text = Convert.ToString(conta.Saldo);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			conta.Saca(Convert.ToDouble(textoValor.Text));
			AtualizaSaldo();
		}
	}
}
