using System;

namespace Exerc_Whi1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("While - Exercicio 1");
            Console.Write("Digite a senha de acesso: "); int senha = int.Parse(Console.ReadLine());
            while (senha != 2002) {
                Console.WriteLine("Senha inválida");
                Console.WriteLine();
                Console.Write("Digite a senha de acesso: "); senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("While - Exercicio 2");
            Console.WriteLine("Digite as coordenadas para saber o quadrante:  Q1 | Q2");
            Console.WriteLine("                                               -------");
            Console.WriteLine("                                               Q3 | Q4");
            Console.Write("Digite as coordenadas X e Y: "); string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while (x != 0 && y != 0) {
                if (x > 0) {
                    if (y > 0) {
                        Console.WriteLine("Quadrante Q2");
                    }
                    else if (y < 0) {
                        Console.WriteLine("Quadrante Q4");
                    }
                    else {
                        Console.WriteLine("Ponto positivo sobre o eixo Y");
                    }
                }
                else if (x < 0) {
                    if (y > 0) {
                        Console.WriteLine("Quadrante Q1");
                    }
                    else if (y < 0) {
                        Console.WriteLine("Quadrante Q3");
                    }
                    else {
                        Console.WriteLine("Ponto negativo sobre o eixo Y");
                    }
                }
                else {
                    if (y > 0) {
                        Console.WriteLine("Positivo sobre o eixo X");
                    }
                    else if (y < 0) {
                        Console.WriteLine("Negativo sobre o eixo X");
                    }
                    else {
                        Console.WriteLine("Neutro");
                    }
                }
                Console.WriteLine();
                Console.Write("Digite as coordenadas X e Y: "); vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }

            Console.WriteLine();
            Console.WriteLine("While -  3");
            Console.WriteLine("Digite código do combustível, sendo 1.Alcool, 2.Gasolina, 3.Diesel e 4.Fim");
            Console.Write("Informe o código: "); int codigo = int.Parse(Console.ReadLine());
            int alcool = 0; int gasolina = 0; int diesel = 0; 
            while (codigo != 4) {
                if (codigo == 1) {
                    alcool++;
                } else if (codigo == 2) {
                    gasolina++;
                } else if(codigo == 3) {
                    diesel++;
                }
                Console.Write("Informe o código: "); codigo = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Muito obrigado");
            Console.WriteLine($"Total alcool: {alcool}");
            Console.WriteLine($"Total gasolina: {gasolina}");
            Console.WriteLine($"Total diesel: {diesel}");
            Console.WriteLine(); Console.WriteLine();

        }
    }
}
