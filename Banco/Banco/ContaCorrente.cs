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
			return base.Saca(valor+0.05);
		}

		public override void Deposita(double valor)
		{
			base.Deposita(valor-0.10);
		}
	}
}
