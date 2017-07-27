using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	public class Conta
	{
		public double Saldo { get; protected set; }
		public Cliente Titular { get; set; }
		public int Numero { get; set; }

		public virtual void Deposita(double valor)
		{
			this.Saldo += valor;
		}

		public virtual bool Saca(double valor)
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
