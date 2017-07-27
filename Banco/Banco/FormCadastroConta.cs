using Banco.Busca;
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
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;
        private ICollection<string> devedores;
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            Conta novaConta;
            string nomeDoTitular = textoTitular.Text;
            bool ehDevedor = false;
            for (int i = 0; i < 30000; i++)
            {
                ehDevedor = this.devedores.Contains(nomeDoTitular);
            }
            if (ehDevedor)
            {
                MessageBox.Show("DEVEDOR!");
            }
            else
            {
                if (comboTipoConta.SelectedIndex == 0)
                {
                    novaConta = new ContaCorrente();
                }
                else
                {
                    novaConta = new ContaPoupanca();
                }
                novaConta.Titular = new Cliente(textoTitular.Text);
                this.formPrincipal.AdicionaConta(novaConta);
            }
            this.Close();
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            comboTipoConta.Items.Add("ContaCorrente");
            comboTipoConta.Items.Add("ContaPoupanca");
            textoNumero.Text = Convert.ToString(Conta.ProximoNumero());
            textoNumero.Enabled = false;
        }
    }
}
