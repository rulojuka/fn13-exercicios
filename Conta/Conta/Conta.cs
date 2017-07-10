using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
	class Conta
	{
		public double Saldo { get; private set; }
		public Cliente titular;
		public int numero;

		public void Deposita(double valor)
		{
			this.Saldo += valor;
		}

		public bool Saca(double valor)
		{
			if (valor <= this.Saldo)
			{
				this.Saldo -= valor;
				return true;
			}
			return false;
		}

		public void Transfere(double valor, Conta destino)
		{
			this.Saca(valor);
			destino.Deposita(valor);
		}

	}
}
