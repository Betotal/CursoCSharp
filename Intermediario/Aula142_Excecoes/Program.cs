using System;
using Aula142_Excecoes.Entities;
using Aula142_Excecoes.Entities.Exceptions;

namespace Aula142_Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
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

                Reserva reserva = new Reserva(quarto, checkin, checkout);
                Console.WriteLine($"Reserva: " + reserva);
                Console.WriteLine();

                Console.WriteLine("Atualização de reserva");
                Console.Write("Data de entrada (dd/mm/aaaa - Check-in): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Data de saida (dd/mm/aaaa - Check-out): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reserva.UpdateReserva(checkin, checkout);
                Console.WriteLine($"Reserva: " + reserva);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Erro no tipo de dados: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}
