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
		private Conta[] contas;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			contas = new Conta[3];

			this.contas[0] = new Conta();
			this.contas[0].Titular = new Cliente("Victor");
			this.contas[0].Numero = 1;

			this.contas[1] = new ContaPoupanca();
			this.contas[1].Titular = new Cliente("mauricio");
			this.contas[1].Numero = 1;

			this.contas[2] = new ContaCorrente();
			this.contas[2].Titular = new Cliente("osni");
			this.contas[2].Numero = 1;

			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int indice = Convert.ToInt32(textoIndice.Text);
			Conta selecionada = this.contas[indice];

			selecionada.Deposita(Convert.ToDouble(textoValor.Text));
			AtualizaSaldo(selecionada);
		}

		private void AtualizaSaldo(Conta conta)
		{
			textoSaldo.Text = Convert.ToString(conta.Saldo);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int indice = Convert.ToInt32(textoIndice.Text);
			Conta selecionada = this.contas[indice];
			selecionada.Saca(Convert.ToDouble(textoValor.Text));
			AtualizaSaldo(selecionada);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int indice = Convert.ToInt32(textoIndice.Text);
			Conta selecionada = this.contas[indice];
			textoNumero.Text = Convert.ToString(selecionada.Numero);
			textoTitular.Text = Convert.ToString(selecionada.Titular.Nome);
			textoSaldo.Text = Convert.ToString(selecionada.Saldo);
		}
	}
}
