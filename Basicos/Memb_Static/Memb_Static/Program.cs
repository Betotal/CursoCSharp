using System;

namespace Memb_Static {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Exercicio de fixação - Menbros Staticos");
            Console.WriteLine();

            Console.Write("Qual o nome da moeda que será convertida: "); ConversorDeMoeda.NomeMoeda = Console.ReadLine();
            Console.Write("Valor unitário da Moeda: "); ConversorDeMoeda.ValorMoeda = double.Parse(Console.ReadLine());
            Console.Write("Quantiade: "); ConversorDeMoeda.QtdeMoeda = int.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago por : {ConversorDeMoeda.QtdeMoeda} {ConversorDeMoeda.NomeMoeda}: {ConversorDeMoeda.ValorEmReais().ToString("F2")}");

            Console.WriteLine("Hello World!");
        }
    }
}
