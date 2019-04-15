using System;
using System.Collections.Generic;
using Aula130_131_Exercicio.Entities;

namespace Aula130_131_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("*****      PROGRAMA PARA INSERCAO DE TRABALHDOR    ******");
            Console.WriteLine();
            Console.Write("Entre com a quantidade de trabalhadores: ");
            int N = int.Parse(Console.ReadLine());

            List<Funcionario> Lista = new List<Funcionario>();


            for (int i = 1; i > N; i++)
            {
                Funcionario func;

                Console.Write("Funcionário contratado (S/N): ");
                char contratado = char.Parse(Console.ReadLine().ToUpper());

                Console.WriteLine($"Dados do {i}# trabalhador");
                Console.Write("Nome do trabalhador: ");
                string nome = Console.ReadLine();

                Console.Write("Horas trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valHora = double.Parse(Console.ReadLine());

                if (contratado == 'S')
                {
                    Console.Write("Informe o valor do Bonus: ");
                    double adicional = double.Parse(Console.ReadLine());
                    Lista.Add(func = new Contratado(nome, horas, valHora, adicional);
                } else
                {
                    Lista.Add(func = new Funcionario(nome, horas, valHora));
                }

                foreach(Funcionario f in Lista)
                {
                    Console.WriteLine(f);
                }


            }


            Console.WriteLine("Hello World!");
        }
    }
}
