using System;
using System.Collections.Generic;
using System.Text;
using Aula122_Enum_Comp_StrBD.Enum;
using Aula122_Enum_Comp_StrBD.Entities;

namespace Aula122_Enum_Comp_StrBD.Entities
{
    class Order
    {
        public DateTime Momento { get; set; };
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens = new List<OrderItem>();
        public Cliente Client { get; set; };

        public Order()
        {
        }

        public Order(DateTime momento, OrderStatus status, List<OrderItem> itens, Cliente client) : this(momento, status)
        {
            Itens = itens;
            Client = client;
        }

        public Order(DateTime momento, OrderStatus status)
        {
            Momento = momento;
            Status = status;
        }

        public void addItem(OrderItem item)
        {
            Itens.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double soma = 0;
            foreach(OrderItem item in Itens)
            {
                soma += item.SubTotal(item.P1);
            }
            return soma;
        }


    }
}
