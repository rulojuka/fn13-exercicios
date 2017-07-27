using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	class ContaPoupanca:Conta
	{
        public override void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public override bool Saca(double valor)
		{
			if ( (valor+0.1) <= this.Saldo)
			{
				this.Saldo -= valor + 0.1;
				return true;
			}
			return false;
		}
	}
}
