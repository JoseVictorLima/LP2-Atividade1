using System;

namespace LP2_Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            int opt = 1;
            decimal taxa;
            String nome;
            taxa = 0.10M;
            nome = "MeuUser";
            DateTime data = new DateTime(1995,06,15);
            ContaCorrente contaC = new ContaCorrente(nome);
            nome = "MeuUserPoupanca";
            ContaPoupanca contaP = new ContaPoupanca(taxa,data,nome);
            for(opt = opt; opt!=0; opt = opt)
            {
                
                if(menu == 0) menu = MenuContaSelec(opt);
                opt = menu;
                if(menu == 1) menu = MenuContaCorrente(opt,menu,contaC);
                else if(menu == 2) menu = MenuContaPoupanca(opt,menu,contaP);
                
            }
            Console.WriteLine("Volte sempre!");
        }

        static int MenuContaSelec(int opt)
        {
            Console.WriteLine(" ");
            Console.WriteLine("------------Menu------------");
            Console.WriteLine("Conta Corrente           - 1");
            Console.WriteLine("Conta Poupanca           - 2");
            Console.WriteLine("Sair                     - 0");
            Console.WriteLine(" ");
            opt = Int32.Parse(Console.ReadLine());
            return opt;
        }

        static int MenuContaCorrente(int opt,int menu,ContaCorrente contaC)
        {
            decimal qnt;
            Console.WriteLine(" ");
            Console.WriteLine("-------Conta Corrente-------");
            Console.WriteLine("------------Menu------------");
            Console.WriteLine("Sacar     - 1");
            Console.WriteLine("Depositar - 2");
            Console.WriteLine("Printar   - 3");
            Console.WriteLine("Voltar    - 4");
            Console.WriteLine(" ");
            opt = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            switch(opt)
            {
                case 1: 
                    Console.WriteLine("Quantidade a sacar:");
                    qnt = decimal.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    sacarCorrente(contaC,qnt);
                break;
                
                case 2: 
                    Console.WriteLine("Quantidade a depositar:");
                    qnt = decimal.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    depositarCorrente(contaC,qnt);
                break;
                
                case 3: 
                    printarCorrente(contaC);
                break;
                case 4 : 
                    menu = 0;
                break;
                default :
                    Console.WriteLine("Opção Invalida");
                break;
            }
            return menu;
        }

        static int MenuContaPoupanca(int opt,int menu,ContaPoupanca contaP)
        {  
            decimal qnt;
            Console.WriteLine(" ");
            Console.WriteLine("-------Conta Poupanca-------");
            Console.WriteLine("------------Menu------------");
            Console.WriteLine("Sacar     - 1");
            Console.WriteLine("Depositar - 2");
            Console.WriteLine("Printar   - 3");
            Console.WriteLine("Voltar    - 4");
            Console.WriteLine(" ");
            opt = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            switch(opt)
            {
                case 1: 
                    Console.WriteLine("Quantidade a sacar:");
                    qnt = decimal.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    sacarPoupanca(contaP,qnt);
                break;
                
                case 2: 
                    Console.WriteLine("Quantidade a depositar:");
                    qnt = decimal.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    depositarPoupanca(contaP,qnt);
                break;
                
                case 3: 
                    printarPoupanca(contaP);
                break;
                case 4 :
                    menu = 0;
                 break;
                default :
                    Console.WriteLine("Opção Invalida");
                break;
            }
            return menu;
        }

        static void printarCorrente(ContaCorrente conta)
        {
            Console.WriteLine("Titular     : " + conta.Id);
            Console.WriteLine("Saldo atual : " + conta.Saldo);
        }
        static void sacarCorrente(ContaCorrente conta,decimal saque)
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

        public static void depositarCorrente(ContaCorrente conta, decimal deposito)
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

        static void printarPoupanca(ContaPoupanca conta)
        {
            Console.WriteLine("Titular     : " + conta.Id);
            Console.WriteLine("Saldo atual : " + conta.Saldo);
        }
        static void sacarPoupanca(ContaPoupanca conta,decimal saque)
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

        public static void depositarPoupanca(ContaPoupanca conta, decimal deposito)
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
