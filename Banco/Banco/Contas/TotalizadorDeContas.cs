using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
	class TotalizadorDeContas
	{
		public double SaldoTotal { get; private set; }

		public void Adiciona(Conta c)
		{
			this.SaldoTotal += c.Saldo;
		}
	}
}
