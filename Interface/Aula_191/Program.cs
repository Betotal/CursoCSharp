<<<<<<< HEAD
﻿using System;
using System.Globalization;
using Aula_191.Entities;
using Aula_191.Services;

namespace Aula_191 {
    class Program {
        static void Main(string[] args) {
   
            Console.WriteLine("Entre com os dados do aluguel");
            Console.WriteLine();
            Console.Write("Modelo do carro: ");
            String modelo = Console.ReadLine();

            Console.Write("Data e hora de Retirada do veiculo (DD/MM/YYYY HH:MM): ");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data e hora de Retorno do veiculo (DD/MM/YYYY HH:MM): ");
            DateTime final = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Informe o valor do aluguel por hora: ");
            double precohora = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do aluguel por dia: ");
            double precodia = double.Parse(Console.ReadLine());

            Aluguel carroAlugado = new Aluguel(inicio, final, new Veiculo(modelo));

            ServicoAluguel Aluguel = new ServicoAluguel(precohora, precodia, new TaxaBrasil());

            Aluguel.ProcessaNota(carroAlugado);

            Console.WriteLine();
            Console.WriteLine($"Nota do aluguel: Modelo - {modelo}");
            Console.WriteLine(carroAlugado.Nota);

            Console.ReadLine();

        }
    }
}
=======
﻿using System;
using System.Globalization;
using Aula_191.Entities;
using Aula_191.Services;

namespace Aula_191 {   //  Aula 203 - Aluguel de Carro
    class Program {
        static void Main(string[] args) {
   
            Console.WriteLine("Entre com os dados do aluguel");
            Console.WriteLine();
            Console.Write("Modelo do carro: ");
            String modelo = Console.ReadLine();

            Console.Write("Data e hora de Retirada do veiculo (DD/MM/YYYY HH:MM): ");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data e hora de Retorno do veiculo (DD/MM/YYYY HH:MM): ");
            DateTime final = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Informe o valor do aluguel por hora: ");
            double precohora = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do aluguel por dia: ");
            double precodia = double.Parse(Console.ReadLine());

            Aluguel carroAlugado = new Aluguel(inicio, final, new Veiculo(modelo));

            //ServicoAluguel Aluguel = new ServicoAluguel(precohora, precodia); // sem interface
            ServicoAluguel Aluguel = new ServicoAluguel(precohora, precodia, new TaxaBrasil()); // com interface

            Aluguel.ProcessaNota(carroAlugado);

            Console.WriteLine();
            Console.WriteLine($"Nota do aluguel: Modelo - {modelo}");
            Console.WriteLine(carroAlugado.Nota);

            Console.ReadLine();

        }
    }
}
>>>>>>> 3aad5c9468bf2c7b282b100811072f9d30221962
