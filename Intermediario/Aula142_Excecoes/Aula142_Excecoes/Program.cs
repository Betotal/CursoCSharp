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

            DateTime now = DateTime.Now;
            if (now > checkin || now > checkout)
            { 
                Console.WriteLine("Reserva só é permitida para datas futuras");
            }
            else {
                if (checkout <= checkin)
                {
                    Console.WriteLine("Data de Check-out deve ser maior que a data de entrada");
                }
                else
                {
                    Reserva reserva = new Reserva(quarto, checkin, checkout);
                    Console.WriteLine($"Reserva: " + reserva);
                    Console.WriteLine();

                    Console.WriteLine("Atualização de reserva");
                    Console.Write("Data de entrada (dd/mm/aaaa - Check-in): ");
                    checkin = DateTime.Parse(Console.ReadLine());

                    Console.Write("Data de saida (dd/mm/aaaa - Check-out): ");
                    checkout = DateTime.Parse(Console.ReadLine());

                    now = DateTime.Now;
                    if (now > checkin || now > checkout)
                    {
                        Console.WriteLine("Reserva só é permitida para datas futuras");
                    }
                    else
                    {
                        if (checkout <= checkin)
                        {
                            Console.WriteLine("Data de Check-out deve ser maior que a data de entrada");
                        }
                        else
                        {
                            Console.WriteLine("Dados atualizados");
                            reserva.UpdateReserva(checkin, checkout);
                            Console.WriteLine($"Reserva: " + reserva);
                        }
                    }
                }

                Console.WriteLine();
            }



            Console.WriteLine("Hello World!");
        }
    }
}
