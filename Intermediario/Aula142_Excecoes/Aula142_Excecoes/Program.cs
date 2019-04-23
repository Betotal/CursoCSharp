using Aula142_Excecoes.Entities;
using System;

namespace Aula142_Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****     USO DE EXCEÇÕES     *****");
            Console.WriteLine();
            Console.Write("Informe o número do Quarto: ");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Data de entrada (dd/mm/aaaa - Check-in): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            Console.Write("Data de saida (dd/mm/aaaa - Check-out): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            Reserva reserva = new Reserva();

            string erro = reserva.VerificaErro(checkin, checkout);
            if (erro != null)
            {
                Console.WriteLine("Erro na reserva: " + erro);
            }
            else
            { 
                reserva.GravaReserva(quarto, checkin, checkout);
                Console.WriteLine($"Reserva: " + reserva);
                Console.WriteLine();

                Console.WriteLine("Atualização de reserva");
                Console.Write("Data de entrada (dd/mm/aaaa - Check-in): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Data de saida (dd/mm/aaaa - Check-out): ");
                checkout = DateTime.Parse(Console.ReadLine());

                erro = reserva.VerificaErro(checkin, checkout);
                if (erro != null)
                {
                    Console.WriteLine("Erro na Atualização: " + erro);
                }
                else
                {
                    Console.WriteLine("Dados atualizados");
                    reserva.UpdateReserva(checkin, checkout);
                    Console.WriteLine($"Reserva: " + reserva);
                }

                Console.WriteLine();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
