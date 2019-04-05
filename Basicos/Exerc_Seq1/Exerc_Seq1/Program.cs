using System;
using System.Globalization;

namespace Exerc_Seq1 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Exercicios Estrutura sequancial 1");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Soma de 2 numeros inteiros");
            Console.Write("Entre com o 1º num: "); int num1 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o 2º num: "); int num2 = int.Parse(Console.ReadLine());
            int soma = num1 + num2;
            Console.WriteLine($"A soma dos numeros {num1} e {num2} é: {soma}");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Outros 2 numeros inteiros");
            Console.Write("Entre com o 1º num: "); num1 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o 2º num: "); num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine($"A soma dos numeros {num1} e {num2} é: {soma}");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Ultima vez.Outros 2 numeros inteiros");
            Console.Write("Entre com o 1º num: "); num1 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o 2º num: "); num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine($"A soma dos numeros {num1} e {num2} é: {soma}");
            Console.WriteLine(); Console.WriteLine();
            
            Console.WriteLine("Exercicio 2 - Calculo da area do circulo");
            double pi = Math.PI;

            Console.Write("Entre com o raio do circulo: "); double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double areaCirculo = pi * Math.Pow(raio,2);
            Console.WriteLine($"A area da circunferência, de raio {raio} é: {areaCirculo.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine(); Console.WriteLine();

            Console.Write("Entre com o raio do circulo: "); raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            areaCirculo = pi * Math.Pow(raio, 2);
            Console.WriteLine($"A area da circunferência, de raio {raio} é: {areaCirculo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(); Console.WriteLine();

            Console.Write("Entre com o raio do circulo: "); raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            areaCirculo = pi * Math.Pow(raio, 2);
            Console.WriteLine($"A area da circunferência, de raio {raio} é: {areaCirculo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Exercicio 3 - Diferênca entre 2 produtos (A*B - C*D)");
            Console.Write("Entre com o 1º num: "); num1 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o 2º num: "); num2 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o 3º num: "); int num3 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o 4º num: "); int num4 = int.Parse(Console.ReadLine());
            int produto = num1 * num2 - num3 * num4;
            Console.WriteLine($"A diferênca entre dois produtos ({num1} * {num2} - {num3} * {num4} é: {produto}");
            Console.WriteLine();

            Console.Write("Entre com o 1º num: "); num1 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o 2º num: "); num2 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o 3º num: "); num3 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o 4º num: "); num4 = int.Parse(Console.ReadLine());
            produto = num1 * num2 - num3 * num4;
            Console.WriteLine($"A diferênca entre dois produtos ({num1} * {num2} - {num3} * {num4} é: {produto}");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Exercicio 4 - Exibe Salario");
            Console.Write("Entre com o número do trabalhador: "); int cracha = int.Parse(Console.ReadLine());
            Console.Write("Qtde de horas trabalhadas: "); int htrab = int.Parse(Console.ReadLine());
            Console.Write("Valor por hora trabalhada: "); double valHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = htrab * valHora;
            Console.WriteLine($"Trabalhador {cracha} tem salário {salario.ToString("F2", CultureInfo.InstalledUICulture)}");
            Console.WriteLine();

            Console.Write("Entre com o número do trabalhador: "); cracha = int.Parse(Console.ReadLine());
            Console.Write("Qtde de horas trabalhadas: ");         htrab = int.Parse(Console.ReadLine());
            Console.Write("Valor por hora trabalhada: ");         valHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = htrab * valHora;
            Console.WriteLine($"Trabalhador {cracha} tem salário {salario.ToString("F2", CultureInfo.InstalledUICulture)}");
            Console.WriteLine(); 

            Console.Write("Entre com o número do trabalhador: "); cracha = int.Parse(Console.ReadLine());
            Console.Write("Qtde de horas trabalhadas: ");         htrab = int.Parse(Console.ReadLine());
            Console.Write("Valor por hora trabalhada: ");         valHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = htrab * valHora;
            Console.WriteLine($"Trabalhador {cracha} tem salário {salario.ToString("F2", CultureInfo.InstalledUICulture)}");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Exercicio 5 - Receba 2 peças e exiba o valor total a pagar");
            Console.Write("Entre com o código da peça 1, valor unitário e a quantidade: "); string[] vet = Console.ReadLine().Split(' ');
            int peca1 = int.Parse(vet[0]);
            double unitario = double.Parse(vet[1], CultureInfo.InvariantCulture);
            int qtde = int.Parse(vet[2]);
            double valPagar = qtde * unitario;
            Console.Write("Entre com o código da peça 2, valor unitário e a quantidade: "); vet = Console.ReadLine().Split(' ');
            int peca2 = int.Parse(vet[0]);
            unitario = double.Parse(vet[1], CultureInfo.InvariantCulture);
            qtde = int.Parse(vet[2]);
            valPagar = valPagar + (qtde * unitario);
            Console.WriteLine($"Valor total a pagar (peça {peca1} e peca {peca2} é: {valPagar.ToString("F2", CultureInfo.InstalledUICulture)}");
            Console.WriteLine();

            Console.Write("Entre com o código da peça 1, valor unitário e a quantidade: "); vet = Console.ReadLine().Split(' ');
            peca1 = int.Parse(vet[0]);
            unitario = double.Parse(vet[1], CultureInfo.InvariantCulture);
            qtde = int.Parse(vet[2]);
            valPagar = qtde * unitario;
            Console.Write("Entre com o código da peça 2, valor unitário e a quantidade: "); vet = Console.ReadLine().Split(' ');
            peca2 = int.Parse(vet[0]);
            unitario = double.Parse(vet[1], CultureInfo.InvariantCulture);
            qtde = int.Parse(vet[2]);
            valPagar = valPagar + (qtde * unitario);
            Console.WriteLine($"Valor total a pagar (peça {peca1} e peca {peca2} é: {valPagar.ToString("F2", CultureInfo.InstalledUICulture)}");
            Console.WriteLine();

            Console.Write("Entre com o código da peça 1, valor unitário e a quantidade: "); vet = Console.ReadLine().Split(' ');
            peca1 = int.Parse(vet[0]);
            unitario = double.Parse(vet[1], CultureInfo.InvariantCulture);
            qtde = int.Parse(vet[2]);
            valPagar = qtde * unitario;
            Console.Write("Entre com o código da peça 2, valor unitário e a quantidade: "); vet = Console.ReadLine().Split(' ');
            peca2 = int.Parse(vet[0]);
            unitario = double.Parse(vet[1], CultureInfo.InvariantCulture);
            qtde = int.Parse(vet[2]);
            valPagar = valPagar + (qtde * unitario);
            Console.WriteLine($"Valor total a pagar (peça {peca1} e peca {peca2} é: {valPagar.ToString("F2", CultureInfo.InstalledUICulture)}");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Exercicio 6 - Calculo aritmético - Triangulo, Circulo, trapézio, quadrado e retângulo");
            Console.WriteLine("Area do Triangulo: (Base x Altura) / 2, sendo A a base e C altura,");
            Console.WriteLine("Area do Circulo: PI * raio², sendo C raio,");
            Console.WriteLine("Area do Trapézio: (Base x Altura) - ((Base maior - B menor) * Altura)/ 2, A Base menor, B Base maior e C Altbase e C altura,");
            Console.WriteLine("Area do Quadrado: Lado², sendo B o lado,");
            Console.WriteLine("Area do Retangulo: (Base x Altura), sendo A a base e B altura, temos");
            
            Console.Write("Informe os valores de A, B e C: "); vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0]);
            double B = double.Parse(vet[1]);
            double C = double.Parse(vet[2]);

            double quadrado = Math.Pow(B,2);
            double retangulo = A * B;
            double circulo = pi * Math.Pow(C, 2);    
            double triangulo = (A * C) / 2;
            double trapezio = (A * C) - (((B - A) * C) / 2);

            Console.WriteLine($"Area do Triangulo: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area do Circulo: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area do Trapézio:{trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area do Quadrado:{quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area do Retangulo:{retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine();

            Console.Write("Informe os valores de A, B e C: "); vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            quadrado = Math.Pow(B, 2);
            retangulo = A * B;
            circulo = pi * Math.Pow(C, 2);    
            triangulo = (A * C) / 2;
            trapezio = (A * C) - (((B - A) * C) / 2);

            Console.WriteLine($"Area do Triangulo: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area do Circulo: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area do Trapézio:{trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area do Quadrado:{quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area do Retangulo:{retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
