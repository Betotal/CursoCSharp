using System;
using Aula115_Enuns.Entities;
using Aula115_Enuns.Entities.Enums;

namespace Aula115_Enuns
{
    class Program
    {
        static void Main(string[] args)
        {
            Order Order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };
            Console.WriteLine(Order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
