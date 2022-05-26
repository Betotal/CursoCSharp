using System;
using System.Globalization;

namespace Aula22 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre com o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine(preco);
            Console.WriteLine();
            Console.WriteLine("Entre com seu último nome, idade e altura (na mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');

            Console.WriteLine("Dados digitados e separados por split:");
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);
            
            Console.WriteLine("Nome: " + nome + " " + sobrenome);
            Console.WriteLine("idade: " + idade);
            Console.WriteLine("Qtde de quartos: " + quartos);
            Console.WriteLine("preço do produto: " + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
