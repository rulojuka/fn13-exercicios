using Banco.Contas;
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
        private List<Conta> contas;
        private Dictionary<string, Conta> dicionario;
        public Form1()
        {
            InitializeComponent();
        }
        public void AdicionaConta(Conta conta)
        {
            this.contas.Add(conta);
            comboContas.Items.Add(conta);
            comboDestinoTransferencia.Items.Add(conta);
            this.dicionario.Add(conta.Titular.Nome, conta);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboContas.DisplayMember = "Titular";
            //comboDestinoTransferencia.DisplayMember = "Titular";
            contas = new List<Conta>();
            dicionario = new Dictionary<string, Conta>();

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
            Conta selecionada = (Conta)comboContas.SelectedItem;
            try
            {
                selecionada.Deposita(Convert.ToDouble(textoValor.Text));
                AtualizaSaldo(selecionada);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Argumento inválido");
            }
        }

        private void AtualizaSaldo(Conta conta)
        {
            textoSaldo.Text = Convert.ToString(conta.Saldo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta selecionada = (Conta)comboContas.SelectedItem;
            try
            {
                selecionada.Saca(Convert.ToDouble(textoValor.Text));
                AtualizaSaldo(selecionada);
            }
            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Valor inválido");
            }
        }


        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            AtualizaCampos(selecionada);
        }

        private void AtualizaCampos(Conta selecionada)
        {
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

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200);

            SeguroDeVida sv = new SeguroDeVida();

            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            totalizador.Adiciona(conta);
            MessageBox.Show("Total: " + totalizador.Total);
            totalizador.Adiciona(sv);
            MessageBox.Show("Total: " + totalizador.Total);

            /*
            MessageBox.Show("imposto da conta corrente = "+conta.CalculaTributos());
            ITributavel t = conta;

            MessageBox.Show("imposto da conta pela interface = " + t.CalculaTributos());

            MessageBox.Show("imposto do seguro = " + sv.CalculaTributos());

            t = sv;
            MessageBox.Show("imposto do seguro pela interface = " + t.CalculaTributos());
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nomeTitular = textoBuscaTitular.Text;
            try
            {
                Conta conta = dicionario[nomeTitular];
                comboContas.SelectedItem = conta;
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Não existe uma conta com esse nome de cliente no dicionário.");
            }
        }
    }
}
