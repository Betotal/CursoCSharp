using System;
using Aula127_3Conceitos.Entities;

namespace Aula127_3Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaC = new ContaCorrente(1001, "Priscila", 500.00);
            ContaPoupanca ContaP = new ContaPoupanca(9001, "Beto", 500.00, 1);
           
            ContaC.RetiradaSaldo(15.0);
            ContaP.RetiradaSaldo(15.0);

            Console.WriteLine(ContaC.Saldo.ToString());
            Console.WriteLine(ContaP.Saldo.ToString());




            Console.WriteLine("Hello World!");
        }
    }
}
