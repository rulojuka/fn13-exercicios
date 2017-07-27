using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	public abstract class Conta
	{
		public double Saldo { get; protected set; }
		public Cliente Titular { get; set; }
		public int Numero { get; set; }

        public abstract void Deposita(double valor);

        public abstract bool Saca(double valor);

		public void Transfere(double valor, Conta destino)
		{
			this.Saca(valor);
			destino.Deposita(valor);
		}

	}
}
