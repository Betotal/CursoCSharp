using System;

namespace Exerc_Matriz_Aula80 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("************     Matriz    **********");
            Console.WriteLine();

            Console.Write("Informe o tamanho da matriz quadrada: ");
            int tam = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] Matriz = new int[tam, tam];
            int x, y;
            Console.WriteLine("Por favor, informe os números da matriz:");
            for (int i = 0; i < tam; i++) {
                x = i + 1;
                Console.Write($"Entre com os dados da {x}ª Linha: ");
                string[] values = Console.ReadLine().Split(" ");

                for (int j = 0; j < tam; j++) {
                    y = j + 1;
                    Matriz[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("****************************");
            Console.WriteLine();
            Console.WriteLine("Dados digitados:");
            for (int i = 0; i < tam; i++) {
                for (int j = 0; j < tam; j++) {
                    Console.Write($"   {Matriz[i, j]}");
                }
                Console.WriteLine();
            }

            Console.Write("Diagonal principal:");
            for (int i = 0; i < tam; i++) {
                Console.Write($"   {Matriz[i,i]}");
            }
            Console.WriteLine();
            Console.WriteLine();

            int negativo = 0;

            for (int i = 0; i < tam; i++) {
                for (int j = 0; j < tam; j++) {
                    if (Matriz[i,j] < 0)
                        negativo ++;
                }
            }
            Console.WriteLine($"Quantidade de valores negativos: {negativo}");

        }
    }
}
