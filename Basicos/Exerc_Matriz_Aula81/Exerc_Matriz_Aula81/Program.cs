using System;

namespace Exerc_Matriz_Aula81
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              desenvolver um programa para carregar uma matriz tamanho N x M
              Pedir pra procurar um numero na matriz;
            Exibir a posição deste numero
            Informar, se houver :
                - O numero a Esquerda;
                - O numero a Direita;
                - O numero acima;
                - O numero abaixo;
             */

            Console.WriteLine("************     Matriz    **********");
            Console.WriteLine();

            Console.Write("Informe o quantidade de linhas: ");
            int linha = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Informe o quantidade de colunas: ");
            int coluna = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int i, j;
            int x;
            int[,] Matriz = new int[linha, coluna];
            Console.WriteLine("Por favor, informe os números da matriz:");
            for (i = 0; i < linha; i++)
            {
                x = i + 1;
                Console.Write($"Entre com os dados da {x}ª Linha: ");
                string[] values = Console.ReadLine().Split(" ");

                for (j = 0; j < coluna; j++)
                {
                    Matriz[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine();
            Console.Write("Digite o número que será pesquisado: ");
            int pesquisa = int.Parse(Console.ReadLine());

            for (i = 0; i < linha; i++)
            {
                for (j = 0; j < coluna; j++)
                {
                    if (Matriz[i, j] == pesquisa)
                    {
                        Console.WriteLine($"Posição na Matriz: {i}, {j}");
                        // esquerda
                        x = j - 1;
                        if (x >= 0)
                        {
                            Console.WriteLine($"Número a esquerda: {Matriz[i, x]}");
                        }
                        // direita
                        x = j + 1;
                        if (x <= linha)
                        {
                            Console.WriteLine($"Número a direita: {Matriz[i, x]}");
                        }
                        // acima
                        x = i - 1;
                        if (x >= 0)
                        {
                            Console.WriteLine($"Número acima: {Matriz[x, j]}");
                        }
                        //abaixo
                        x = i + 1;
                        if (x <= coluna)
                        {
                            Console.WriteLine($"Número abaixo: {Matriz[x, j]}");
                        }
                        Console.WriteLine();
                    }
                }
            }

            foreach (int obj in Matriz)
            {
                if (obj == pesquisa)
                {
                    Console.WriteLine($"Posição na Matriz digitada: ");
                }
            }

        }
    }
}
