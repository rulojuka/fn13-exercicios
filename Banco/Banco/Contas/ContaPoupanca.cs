using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
	class ContaPoupanca:Conta
	{
        public override void Deposita(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException();
            }
            this.Saldo += valor;
        }

        public override void Saca(double valor)
		{
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            else if (this.Saldo < valor + 0.1)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valor + 0.1;
            }
        }
	}
}
