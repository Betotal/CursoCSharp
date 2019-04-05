using System;

namespace Exerc_Cond1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Exercicio 1 - Inteiro Negativo Sim ou não");
            Console.Write("Digite o 1º numero"); int negativo = int.Parse(Console.ReadLine());
            if (negativo < 0) {
                Console.WriteLine($"Número {negativo} é NEGATIVO");
            }
            else {
                Console.WriteLine($"Número {negativo} é NÃO NEGATIVO");
            }
            Console.WriteLine();

            Console.Write("Digite o 2º numero"); negativo = int.Parse(Console.ReadLine());
            if (negativo < 0) {
                Console.WriteLine($"Número {negativo} é NEGATIVO");
            }
            else {
                Console.WriteLine($"Número {negativo} é NÃO NEGATIVO");
            }
            Console.WriteLine();

            Console.Write("Digite o 3º numero"); negativo = int.Parse(Console.ReadLine());
            if (negativo < 0) {
                Console.WriteLine($"Número {negativo} é NEGATIVO");
            }
            else {
                Console.WriteLine($"Número {negativo} é NÃO NEGATIVO");
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Exercicio 2 - Inteiro Par ou Impar");
            Console.Write("Digite o 1º numero"); int resto = int.Parse(Console.ReadLine()) % 2;
            if (resto == 0) {
                Console.WriteLine("O Número é PAR");
            }
            else {
                Console.WriteLine("O Número IMPAR");
            }
            Console.WriteLine();

            Console.Write("Digite o 2º numero"); resto = int.Parse(Console.ReadLine()) % 2;
            if (resto == 0) {
                Console.WriteLine("O Número é PAR");
            }
            else {
                Console.WriteLine("O Número IMPAR");
            }
            Console.WriteLine();

            Console.Write("Digite o 3º numero"); resto = int.Parse(Console.ReadLine()) % 2;
            if (resto == 0) {
                Console.WriteLine("O Número é PAR");
            }
            else {
                Console.WriteLine("O Número IMPAR");
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Exercicio 3 - Inteiro Multiplos");
            Console.Write("Digite os numeros"); string[] vet = Console.ReadLine().Split(' ');
            int num1 = int.Parse(vet[0]);
            int num2 = int.Parse(vet[1]);

            if (num1 > num2) {
                if ((num1 % num2) == 0) {
                    Console.WriteLine($"Numeros {num1} e {num2} não multiplos");
                }
                else {
                    Console.WriteLine($"Numeros {num1} e {num2} NÃO são multiplos");
                }

            }
            else if ((num2 % num1) == 0) {
                Console.WriteLine($"Numeros {num1} e {num2} não multiplos");
            }
            else {
                Console.WriteLine($"Numeros {num1} e {num2} NÃO são multiplos");
            }
            Console.WriteLine();

            Console.Write("Digite os numeros"); vet = Console.ReadLine().Split(' ');
            num1 = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);

            if (num1 > num2) {
                if ((num1 % num2) == 0) {
                    Console.WriteLine($"Numeros {num1} e {num2} não multiplos");
                }
                else {
                    Console.WriteLine($"Numeros {num1} e {num2} NÃO são multiplos");
                }

            }
            else if ((num2 % num1) == 0) {
                Console.WriteLine($"Numeros {num1} e {num2} não multiplos");
            }
            else {
                Console.WriteLine($"Numeros {num1} e {num2} NÃO são multiplos");
            }
            Console.WriteLine();

            Console.Write("Digite os numeros"); vet = Console.ReadLine().Split(' ');
            num1 = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);

            if (num1 > num2) {
                if ((num1 % num2) == 0) {
                    Console.WriteLine($"Numeros {num1} e {num2} não multiplos");
                }
                else {
                    Console.WriteLine($"Numeros {num1} e {num2} NÃO são multiplos");
                }

            }
            else if ((num2 % num1) == 0) {
                Console.WriteLine($"Numeros {num1} e {num2} não multiplos");
            }
            else {
                Console.WriteLine($"Numeros {num1} e {num2} NÃO são multiplos");
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Exercicio 4 - Inteiro Hora do jogo");
            Console.Write("Digite a hora inicial e final"); vet = Console.ReadLine().Split(' ');
            int hInicial = int.Parse(vet[0]);
            int hFinal = int.Parse(vet[1]);
            int duracao;
            if (hInicial < hFinal) {
                duracao = hFinal - hInicial;
            }
            else if (hInicial == hFinal) {
                duracao = 24;
            }
            else {
                duracao = hInicial + 24 - hFinal;
            }
            Console.WriteLine($"A duração do jogo foi {duracao} horas");
            Console.WriteLine();

            Console.Write("Digite a hora inicial e final"); vet = Console.ReadLine().Split(' ');
            hInicial = int.Parse(vet[0]);
            hFinal = int.Parse(vet[1]);
            if (hInicial < hFinal) {
                duracao = hFinal - hInicial;
            }
            else if (hInicial == hFinal) {
                duracao = 24;
            }
            else {
                duracao = hInicial + 24 - hFinal;
            }
            Console.WriteLine($"A duração do jogo foi {duracao} horas");
            Console.WriteLine();
            Console.Write("Digite a hora inicial e final"); vet = Console.ReadLine().Split(' ');
            hInicial = int.Parse(vet[0]);
            hFinal = int.Parse(vet[1]);
            if (hInicial < hFinal) {
                duracao = hFinal - hInicial;
            }
            else if (hInicial == hFinal) {
                duracao = 24;
            }
            else {
                duracao = hInicial + 24 - hFinal;
            }
            Console.WriteLine($"A duração do jogo foi {duracao} horas");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Exercicio 5 - Inteiro Valor total");
            Console.WriteLine("Código        Descrição            Preço");
            Console.WriteLine("   1          Cachorro Quente      R$ 4,00");
            Console.WriteLine("   2          Cheese Salada        R$ 4,50");
            Console.WriteLine("   3          Cheese Bacon         R$ 5,00");
            Console.WriteLine("   4          Misto Quente         R$ 3,50");
            Console.WriteLine("   5          Refrigerante         R$ 1,50");
            Console.WriteLine();
            Console.Write("Digite o codigo e quantidade "); vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int qtde = int.Parse(vet[1]);
            double total;
            vet[0] = Convert.ToString(4.0);
            vet[2] = Convert.ToString(5.0);
            vet[3] = Convert.ToString(3.5);
            vet[4] = Convert.ToString(1.5);

            int indice = codigo - 1;
            total = qtde * Convert.ToDouble(vet[indice]);
            Console.WriteLine($"O valor de {qtde} unidade(s) do codigo {codigo} é {total.ToString("F2")} ");
            Console.WriteLine();

            Console.Write("Digite o codigo e quantidade"); vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            qtde = int.Parse(vet[1]);
            if (codigo == 1) {
                total = qtde * Convert.ToDouble(vet[0]);
            }
            else if (codigo == 2) {
                total = qtde * Convert.ToDouble(vet[1]);
            }
            else if (codigo == 3) {
                total = qtde * Convert.ToDouble(vet[2]);
            }
            else if (codigo == 4) {
                total = qtde * Convert.ToDouble(vet[3]);
            }
            else {
                total = qtde * Convert.ToDouble(vet[4]);
            }
            Console.WriteLine($"O valor de {qtde} unidade(s) do codigo {codigo} é {total.ToString("F2")} ");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Exercicio 6 - Valor dentro do intervalo [0 - 25], [25 * 50 ], [50 - 75], [75 *  100] e fora dos intervalos");
            Console.Write("Digite o numero para consulta: "); double num3 = double.Parse(Console.ReadLine());
            if (num3 >= 0 && num3 <= 25) {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta no intervalo 0 - 25");
            }
            else if (num3 > 25 && num3 <= 50) {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta no intervalo 25 - 50");
            }
            else if (num3 > 50 && num3 <= 75) {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta no intervalo 50 - 75");
            }
            else if (num3 > 75 && num3 <= 100) {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta no intervalo 75 - 100");
            }
            else {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta FORA do(s) intervalos");
            }
            Console.WriteLine();

            Console.Write("Digite o numero para consulta: "); num3 = double.Parse(Console.ReadLine());
            if (num3 >= 0 && num3 <= 25) {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta no intervalo 0 - 25");
            }
            else if (num3 > 25 && num3 <= 50) {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta no intervalo 25 - 50");
            }
            else if (num3 > 50 && num3 <= 75) {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta no intervalo 50 - 75");
            }
            else if (num3 > 75 && num3 <= 100) {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta no intervalo 75 - 100");
            }
            else {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta FORA do(s) intervalos");
            }
            Console.WriteLine();

            Console.Write("Digite o numero para consulta: "); num3 = double.Parse(Console.ReadLine());
            if (num3 >= 0 && num3 <= 25) {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta no intervalo 0 - 25");
            }
            else if (num3 > 25 && num3 <= 50) {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta no intervalo 25 - 50");
            }
            else if (num3 > 50 && num3 <= 75) {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta no intervalo 50 - 75");
            }
            else if (num3 > 75 && num3 <= 100) {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta no intervalo 75 - 100");
            }
            else {
                Console.WriteLine($"O numero {num3.ToString("F2")} esta FORA do(s) intervalos");
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Exercicio 7 - Digite uma posição no plano cartesiano - Retorno do quadrante, sendo");
            Console.WriteLine("                                                         Q1 | Q2");
            Console.WriteLine("                                                         -------");
            Console.WriteLine("                                                         Q3 | Q4");
            Console.Write("Digite X e Y: "); vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0]);
            double y = double.Parse(vet[1]);

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

            Console.Write("Digite X e Y: "); vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0]);
            y = double.Parse(vet[1]);

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

            Console.Write("Digite X e Y: "); vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0]);
            y = double.Parse(vet[1]);

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
            Console.WriteLine(); Console.WriteLine();

        }
    }
}
        

