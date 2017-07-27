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
        private int numeroDeContas;
		public Form1()
		{
			InitializeComponent();
		}
        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add("titular: " + conta.Titular.Nome);
            comboDestinoTransferencia.Items.Add("titular: " + conta.Titular.Nome);
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			contas = new Conta[10];

            Conta aux;
			aux = new ContaCorrente();
			aux.Titular = new Cliente("Victor");
			aux.Numero = 1;
            this.AdicionaConta(aux);

			aux = new ContaPoupanca();
			aux.Titular = new Cliente("mauricio");
			aux.Numero = 2;
            this.AdicionaConta(aux);

            aux = new ContaCorrente();
			aux.Titular = new Cliente("osni");
			aux.Numero = 3;
            this.AdicionaConta(aux);
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int indice = comboContas.SelectedIndex;
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
			int indice = comboContas.SelectedIndex;
			Conta selecionada = this.contas[indice];
			selecionada.Saca(Convert.ToDouble(textoValor.Text));
			AtualizaSaldo(selecionada);
		}


		private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
		{
			int indice = comboContas.SelectedIndex;
			Conta selecionada = this.contas[indice];
			textoNumero.Text = Convert.ToString(selecionada.Numero);
			textoTitular.Text = Convert.ToString(selecionada.Titular.Nome);
			textoSaldo.Text = Convert.ToString(selecionada.Saldo);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int indiceOrigem = comboContas.SelectedIndex;
			Conta origem = this.contas[indiceOrigem];

			int indiceDestino = comboDestinoTransferencia.SelectedIndex;
			Conta destino = this.contas[indiceDestino];

			double valor = Convert.ToDouble(textoValor.Text);

			origem.Transfere(valor, destino);
			AtualizaSaldo(origem);
		}

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioCadastro = new FormCadastroConta(this);
            formularioCadastro.ShowDialog();
        }
    }
}
