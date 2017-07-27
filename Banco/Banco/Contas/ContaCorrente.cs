using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
	class ContaCorrente:Conta,ITributavel
	{
		public override void Saca(double valor)
		{
            if(valor < 0.0)
            {
                throw new ArgumentException();
            }
            else if(this.Saldo < valor + 0.05)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valor + 0.05;
            }
		}

		public override void Deposita(double valor)
		{
            if (valor < 0)
            {
                throw new ArgumentException();
            }
            this.Saldo += valor - 0.10;
		}

        public double CalculaTributos()
        {
            return this.Saldo * 0.05;
        }
    }
}
