using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	class ContaCorrente:Conta
	{
		public override bool Saca(double valor)
		{
            if(this.Saldo >= valor + 0.05)
            {
                this.Saldo -= valor + 0.05;
                return true;
            }
            else
            {
                return false;
            }
		}

		public override void Deposita(double valor)
		{
            this.Saldo += valor - 0.10;
		}
	}
}
