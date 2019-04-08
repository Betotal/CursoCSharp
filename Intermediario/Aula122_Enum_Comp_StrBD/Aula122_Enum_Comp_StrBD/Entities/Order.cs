using System;
using System.Collections.Generic;
using System.Text;
using Aula122_Enum_Comp_StrBD.Enum;

namespace Aula122_Enum_Comp_StrBD.Entities
{
    class Order
    {
        public DateTime Momento { get; set; };
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens = new List<OrderItem>();

        public Order()
        {
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




    }
}
