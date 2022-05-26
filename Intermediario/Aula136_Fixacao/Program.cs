using System;
using System.Collections.Generic;
using Aula136_Fixacao.Entities;

namespace Aula136_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********     CADASTRO DE PESSOA FISICA/ JURIDICA     **********");

            Console.Write("Digite a quantidade de contribuintes: ");
            int N = int.Parse(Console.ReadLine());

            List<Pessoa> Lista = new List<Pessoa>();

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Informe: Pessoa Física(F) ou Pessoa Juridica(J): ");
                char pessoa = char.Parse(Console.ReadLine());

                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Informe a Renda Anual: ");
                double renda = double.Parse(Console.ReadLine());

                int taxa;
                if (pessoa == 'F' || pessoa == 'f')
                {
                    Console.Write("Despesas com Saude: ");
                    double despesas = double.Parse(Console.ReadLine());
                    Lista.Add(new PessoaFisica(nome, renda, despesas));
                }
                else
                {
                    Console.Write("Quantidade de funcionários: ");
                    int qtdefunc = int.Parse(Console.ReadLine());
                    Lista.Add(new PessoaJuridica(nome, renda, qtdefunc));
                }
                Console.WriteLine();
            }
          
            double soma = 0.0;
            foreach(Pessoa p in Lista)
            {
                Console.WriteLine(p.Nome + "- Imposto: $" + p.Imposto.ToString("F2"));
                soma += p.Imposto;
            }

            Console.WriteLine();
            Console.WriteLine($"Total de Impostos: ${soma.ToString("F2")}");
        }
    }
}
