using System;

namespace Exerc_For1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("FOR - Exercicio 1");
            Console.Write("Digite um numero entre 1 e 1000. Serão exibidos somente os impares: "); int num1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num1; i++) {
                if ((i % 2) == 1) {
                    Console.WriteLine(i);
                }  
            }
            Console.WriteLine();
        
            Console.WriteLine("FOR - Exercicio 2");
            Console.Write("Informe a qtde de numeros inteiros. Será exibida a qtonde dentro de intervalo 10 à 20: "); num1 = int.Parse(Console.ReadLine());
            int varIn = 0;
            int varOut = 0;
            for (int i = 1; i <= num1; i++) {
                Console.Write($"Digite o {i}º numero: "); int num2 = int.Parse(Console.ReadLine());
                if (num2 >= 10 && num2 <= 20) {
                    varIn++;
                }
                else {
                    varOut++;
                }
            }
            Console.WriteLine($"Foram digitados {varIn} numeros no intervalo 10 à 20 e {varOut} numeros fora do intervalo.");
            Console.WriteLine();

            Console.WriteLine("FOR - Exercicio 3 - Média Ponderada");
            Console.Write("Informe a qtde de calculos para media (1º peso 2, o 2º peso 3 e o 3º peso 5: "); num1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num1; i++) {
                Console.WriteLine($"Digite os 3 números ({i}): "); string [] vet = Console.ReadLine().Split(' ');
                double num2 = double.Parse(vet[0]);
                double num3 = double.Parse(vet[1]);
                double num4 = double.Parse(vet[2]);
              
                double num5 = ((num2 * 2.0) + (num3 * 3.0) + (num4 * 5.0)) / 10;
                Console.WriteLine($"Média ponderada: {num5}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("FOR - Exercicio 4 - Média Ponderada");
            Console.Write("Informe a qtde de calculos número, para divisão "); num1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num1; i++) {
                Console.Write($"Digite os 2 números ({i}) dividendo e divisor: "); string[] vet = Console.ReadLine().Split(' ');
                int num2 = int.Parse(vet[0]);
                int num3 = int.Parse(vet[1]);
                double num4 = 0;
                if (num3 != 0) {
                    num4 = num2 / num3;
                    Console.WriteLine($"Resultado  divisão ({num2} por {num3}: {num4.ToString("F2")}");
                }
                else {
                    Console.WriteLine($"Divisão inválida ({num2} por {num3})");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("FOR - Exercicio 5 - Fatoração");
            Console.Write("Informe a qtde de calculos números: "); num1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num1; i++) {
                Console.Write($"Digite O {i}º número: "); int num2 = int.Parse(Console.ReadLine());
                int fator = 1;
                for (int a = 1; a <= num2; a++) {
                    fator = fator * a;
                }
                Console.WriteLine($"Resultado fatoração de {num2}: {fator.ToString()}");
                Console.WriteLine();
            }
            



            Console.WriteLine("Hello World!");
        }
    }
}
