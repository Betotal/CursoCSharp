using System;

namespace Prim_Exerc {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: "); p1.Nome = Console.ReadLine();
            Console.Write("Digite a idade: "); p1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da segunda pessoa: "); p2.Nome = Console.ReadLine();
            Console.Write("Digite a idade: "); p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade) {
                Console.WriteLine($"A pessoa mais velha é {p1.Nome}, com {p1.Idade} anos.");
            }
            else {
                Console.WriteLine($"A pessoa mais velha é {p2.Nome}, com {p2.Idade} anos.");
            }
            Console.WriteLine(); Console.WriteLine();

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.Write("Digite o nome do primeiro Funcionário "); f1.Nome = Console.ReadLine();
            Console.Write("Digite o salário: "); f1.Salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o nome do segundo Funcionário: "); f2.Nome = Console.ReadLine();
            Console.Write("Digite a salário: "); f2.Salario = double.Parse(Console.ReadLine());

            double mediaSalario = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine($"A média salarial é de R$ {mediaSalario.ToString("F2")}");
        }
    }
}
