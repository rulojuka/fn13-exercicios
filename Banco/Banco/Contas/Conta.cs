using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
	public abstract class Conta
	{
		public double Saldo { get; protected set; }
		public Cliente Titular { get; set; }
		public int Numero { get; set; }
        private static int numeroDeContas;

        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }

        public abstract void Deposita(double valor);

        public abstract void Saca(double valor);

		public void Transfere(double valor, Conta destino)
		{
			this.Saca(valor);
			destino.Deposita(valor);
		}

        public static int ProximoNumero()
        {
            return Conta.numeroDeContas + 1;
        }

        public override string ToString()
        {
            return "Titular: " + this.Titular.Nome;
        }

    }
}
