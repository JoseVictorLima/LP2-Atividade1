using System;

namespace LP2_Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt = 1;
            decimal qnt;
            String nome;
            nome = "MeuUser";
            DateTime data = new DateTime(1995,06,15);
            ContaCorrente contaC = new ContaCorrente(nome);
            for(opt = opt; opt!=0; opt = opt)
            {
                Console.WriteLine(" ");
                Console.WriteLine("-------Menu-------");
                Console.WriteLine("Sacar     - 1");
                Console.WriteLine("Depositar - 2");
                Console.WriteLine("Printar   - 3");
                Console.WriteLine("Sair      - 0");
                Console.WriteLine(" ");
                opt = Int32.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                switch(opt)
                {
                    case 1: 
                        Console.WriteLine("Quantidade a sacar:");
                        qnt = decimal.Parse(Console.ReadLine());
                        Console.WriteLine(" ");
                        sacar(contaC,qnt);
                    break;
                    
                    case 2: 
                        Console.WriteLine("Quantidade a depositar:");
                        qnt = decimal.Parse(Console.ReadLine());
                        Console.WriteLine(" ");
                        depositar(contaC,qnt);
                    break;
                    
                    case 3: 
                        printar(contaC);
                    break;

                    case 0 : break;

                    default :
                        Console.WriteLine("Opção Invalida");
                    break;
                }
            }
            Console.WriteLine("Volte sempre!");
        }

        static void printar(ContaCorrente conta)
        {
            Console.WriteLine("Titular     : " + conta.Id);
            Console.WriteLine("Saldo atual : " + conta.Saldo);
        }
        static void sacar(ContaCorrente conta,decimal saque)
        {
            decimal saldoAnterior;
            try
            {
                saldoAnterior = conta.Saldo;
                conta.Sacar(saque);
                Console.WriteLine("Titular     : " + conta.Id);
                Console.WriteLine("Saldo       : " + saldoAnterior);
                Console.WriteLine("           -  " + saque);
                Console.WriteLine("           +  Desconto");
                Console.WriteLine("----------------------");
                Console.WriteLine("Saldo Atual : " + conta.Saldo);
            } catch(Exception error)
            {
                Console.WriteLine("Não foi possivel efetuar esta ação");
            }
        }

        public static void depositar(ContaCorrente conta, decimal deposito)
        {
            decimal saldoAnterior;
            try
            {
                saldoAnterior = conta.Saldo;
                conta.Depositar(deposito);
                Console.WriteLine("Titular     : " + conta.Id);
                Console.WriteLine("Saldo       : " + saldoAnterior);
                Console.WriteLine("            + " + deposito);
                Console.WriteLine("            - Desconto");
                Console.WriteLine("----------------------");
                Console.WriteLine("Saldo Atual : " + conta.Saldo);
            } catch(Exception error)
            {
                Console.WriteLine("Não foi possivel efetuar esta ação");
            }

        }
    }
}
