using System;

namespace LP2_Atividade1
{
    public class ContaPoupanca : Conta
    {
      private decimal taxaJuros;
      private DateTime dataAniversario;

      public ContaPoupanca(decimal j, DateTime d, string t) : base(t)
      {
          this.taxaJuros = j;
          this.dataAniversario = d;
      }

      public decimal Juros
      {
          get{return taxaJuros;}
          set{this.taxaJuros = value;}
      }

      public DateTime DataAniversario
      {
          get;
      }

      public void  AdicionarRendimento()
      {
          if(DateTime.Now.Equals(this.dataAniversario))
          {
              decimal rendimento;
              rendimento = Saldo * taxaJuros;
              Depositar(rendimento);
          }
      }

      public override string Id
      {
          get{ return Titular + " (CP)";}
      }

      public override void Depositar(decimal valor)
        {
            base.Depositar(valor);
        }

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor);
        }

    }
}