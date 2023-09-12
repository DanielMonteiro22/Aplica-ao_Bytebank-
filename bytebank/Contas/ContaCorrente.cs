using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; set; }

        private int numero_agencia;

        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set
            {
                if(value > 0)
                { this.numero_agencia = value; }
            }
        }

        //private  string conta;

        public string conta { get; set; }

        private double saldo = 100;

        public Cliente titular { get; set; }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }

        public void SetSaldo(Double valor)
        {
            if(valor < 0 )
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo ()
        {
            return this.saldo;
        }

        public ContaCorrente(int numero_agencia, string conta)
        {
            this.numero_agencia = numero_agencia;
            this.conta = conta;
            TotalDeContasCriadas++;
        }
    }
}
