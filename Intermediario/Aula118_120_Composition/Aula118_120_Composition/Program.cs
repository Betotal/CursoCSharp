using System;
using System.Collections.Generic;
using Aula118_120_Composition.Entities.Enums;
using Aula118_120_Composition.Entities;

namespace Aula118_120_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Programa exemplo - usando composição (Composition) **********");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Departamento: ");
            string deptoName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Dados do trabalhador");
            Console.Write("Nome: "  );
            string trabName = Console.ReadLine();

            Console.Write("Nivel do trabalhador <Junior/Pleno/Senior>: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Salario Base: ");
            double SalarioBase = double.Parse(Console.ReadLine());

            Departamento depto = new Departamento(deptoName);
            Trabalhador worker = new Trabalhador(trabName, level, SalarioBase, depto);
            Console.WriteLine();

            Console.Write("Digite quantos contratos o trabalhador terá?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do Contrato #{i}: ");
                Console.Write("Data do contrato: ");
                DateTime DataContrato = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double ValHora = double.Parse(Console.ReadLine());

                Console.Write("Duração do contrato: ");
                int CargaHora = int.Parse(Console.ReadLine());

                HoraContrato TrabContrato = new HoraContrato(DataContrato, ValHora, CargaHora);

                worker.addContrato(TrabContrato);

                Console.WriteLine();
            }

            Console.Write("Ente com o mês e ano para calculo de ganho (MM/AAAA): "  );
            string MesAno = Console.ReadLine();
            int mes = int.Parse(MesAno.Substring(0, 2));
            int ano = int.Parse(MesAno.Substring(3));

            Console.WriteLine($"Nome do trabalhador: {worker.Name}");
            Console.WriteLine($"Departamento: {worker.Departamento.Name}");
            Console.WriteLine($"Ganhos em {MesAno}: {worker.Ganho(ano,mes)}"  );

        }
    }
}
