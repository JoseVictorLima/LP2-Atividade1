using System;

namespace LP2_Atividade1
{
    public abstract class Conta
    {
        private decimal saldo;
        private String titular;

        public decimal Saldo
        {
            get {return this.saldo;}
        }
        public string Titular
        {
            get {return this.titular;}
        }
        public Conta(string t)
        {
            this.titular = t;
        }

        public abstract string Id
        {
            get;
        }

        public virtual void Depositar(decimal valor)
        {
            this.saldo += valor;
        }

        public virtual void Sacar(decimal valor)
        {
            if(valor <= this.saldo)
            {
                this.saldo -= valor;
            }
        }

    }
}