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
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;
        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
            labelSaldoTotal.Text = "";
            labelMaiorSaldo.Text = "";
        }

        private void botaoFiltroSaldo_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            //var resultado = this.contas.Where(c => c.Saldo > 5000);
            var resultado = from c in contas
                            where c.Saldo > 5000
                            orderby c.Titular.Nome, c.Numero
                            select c;
            foreach (var c in resultado)
            {
                listaResultado.Items.Add(c);
            }
            double saldoTotal = resultado.Sum(c => c.Saldo);
            double maiorSaldo = resultado.Max(c => c.Saldo);

            labelMaiorSaldo.Text = Convert.ToString(maiorSaldo);
            labelSaldoTotal.Text = Convert.ToString(saldoTotal);
        }

        private void botaoAntigas_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            //var resultado = this.contas.Where(c => c.Saldo > 1000 && c.Numero < 10);
            var resultado = from c in contas
                            where c.Saldo > 1000 && c.Numero < 10
                            orderby c.Titular.Nome, c.Numero
                            select c;
            foreach (var c in resultado)
            {
                listaResultado.Items.Add(c);
            }
            double saldoTotal = resultado.Sum(c => c.Saldo);
            double maiorSaldo = resultado.Max(c => c.Saldo);

            labelMaiorSaldo.Text = Convert.ToString(maiorSaldo);
            labelSaldoTotal.Text = Convert.ToString(saldoTotal);
        }
    }
}
