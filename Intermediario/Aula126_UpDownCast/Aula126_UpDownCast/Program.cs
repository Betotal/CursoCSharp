using System;
using Aula126_UpDownCast.Entities;

namespace Aula126_UpDownCast
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente Conta = new ContaCorrente(1001, "Priscila", 0.0);
            ContaEspecial ContaE = new ContaEspecial(1002, "Beto", 200.00, 500.00);

            // UPCASTING
            ContaCorrente Conta1 = ContaE;
            ContaCorrente Conta2 = new ContaEspecial(1003, "Helena", 100.00, 300.00);
            ContaCorrente Conta4 = new ContaPoupanca(9001, "Heitor", 100.00, 1.0);

            //DOWNCASTING
            //ContaEspecial ContaE1 = Conta2;
            /*Não aceita, pois o compilador verifica o tipo de variável <ContaCorrente>, 
              mesmo ela recedendo dados de subtipo <ContaEspecial> */
            ContaEspecial ContaE1 = (ContaEspecial)Conta2;
            ContaE1.Emprestimo(200.00);
            //Conta2.Emprestimo(200.00); Não funciona, pois emprestimo é uma operacao da classe ContaEspecicial
            
            //ContaEspecial ContaE3 = (ContaEspecial)Conta4;
            // Não dara erro de compilação, mas gerará uma exceção, pois Conta4 é um objeto do Tipo ContaPoupança
            // e em tempo de execução da erro  

            if (Conta4 is ContaEspecial)
            {
             //   ContaEspecial ContaE3 = (ContaEspecial)Conta4;
                ContaEspecial ContaE3 = Conta4 as ContaEspecial;
                ContaE3.Emprestimo(150.00);
            } if (Conta4 is ContaPoupanca)
            { 
             //   ContaPoupanca ContaP = (ContaPoupanca)Conta4;
                ContaPoupanca ContaP = Conta4 as ContaPoupanca;
                ContaP.AtualizaSaldo(2.0);  
            }


            Console.WriteLine("Hello World!");
        }
    }
}
