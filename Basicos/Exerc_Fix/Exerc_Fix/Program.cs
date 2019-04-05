using System;

namespace Exerc_Fix {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Exercicio 1 - Retangulo");

            Retangulo Ret = new Retangulo();    

            Console.Write("Digite a altura do Retangulo: ");  Ret.Altura  = double.Parse(Console.ReadLine());
            Console.Write("Digite a largura do Retangulo: "); Ret.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Area: {Ret.Area().ToString("F2")}" );
            Console.WriteLine($"Perimetro: {Ret.Primetro().ToString("F2")}");
            Console.WriteLine($"Diagonal: {Ret.Diagonal().ToString("F2")}");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Exercicio 2 - Funcionario");
            
            Funcionario Func = new Funcionario();

            Console.Write("Digite a Nome do Funcionário: "); Func.Nome = Console.ReadLine();
            Console.Write("Digite a Salario do Funcionário: "); Func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Digite o Imposto: "); Func.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Funcionário: {Func}");
            Console.WriteLine();
            Console.Write("Digite a porcentagem de aumento: "); Func.AumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine($"Funcionário: {Func}");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Exercicio 3 - Aluno");

            for (int i = 1; i <= 2; i++) {

                Aluno Alun = new Aluno();

                Console.Write("Digite a Nome do Aluno: "); Alun.Nome = Console.ReadLine();
                Console.Write("Digite a 1ª Nota: "); Alun.Nota1 = double.Parse(Console.ReadLine());
                Console.Write("Digite a 2ª Nota: "); Alun.Nota2 = double.Parse(Console.ReadLine());
                Console.Write("Digite a 3ª Nota: "); Alun.Nota3 = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine($"Nota final do aluno(a): {Alun.Nome}: {Alun.CalculoFinal().ToString("F2")}");
                Console.WriteLine($"Situação do Aluno: {Alun.Situacao()}");
                if (Alun.NotaFinal < 60) {
                    Console.WriteLine($"Nota Faltante: {Alun.NotaFaltante()}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
