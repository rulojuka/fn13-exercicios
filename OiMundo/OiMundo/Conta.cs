using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
	class Conta
	{
		public double saldo;
		public string titular;
		public int numero;

		public void Deposita(double valor)
		{
			this.saldo += valor;
		}

		public bool Saca(double valor)
		{
			if (valor <= this.saldo)
			{
				this.saldo -= valor;
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
