using System;

namespace Exerc_Aula71_Array {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("*******   PRORGRAMA PARA EXERCICIO DE ARRAY DE OBJETOS  ******** ");
            Console.WriteLine();

            Console.Write("Digite a quantidade de Locatários: "); int room = int.Parse(Console.ReadLine());

            Quarto[] Q1 = new Quarto[10];

            int j;

            for (int i = 0; i < room; i++) {
                j = i + 1;
                Console.WriteLine();
                Console.Write("Digite o número do quarto <0 a 9>: "); int numQuarto = int.Parse(Console.ReadLine());
                Console.Write("Digite o NOME do locatário " + j + ": "); string locatario = Console.ReadLine();
                Console.Write("Digite o EMAIL do locatário: ");          string email = Console.ReadLine();

                Q1[numQuarto] = new Quarto(locatario, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < 10; i++) {
                if (Q1[i] != null)
                    Console.WriteLine($"Quarto {i} - Locatário: {Q1[i].Nome}  - E-mail: {Q1[i].Email} ");
                else 
                    Console.WriteLine($"Quarto {i} vago");

            }
        }
    }
}
