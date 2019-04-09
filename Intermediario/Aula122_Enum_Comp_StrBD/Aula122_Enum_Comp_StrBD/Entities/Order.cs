using System;
using System.Collections.Generic;
using System.Text;
using Aula122_Enum_Comp_StrBD.Enum;
using Aula122_Enum_Comp_StrBD.Entities;

namespace Aula122_Enum_Comp_StrBD.Entities
{
    class Order
    {
        public DateTime Momento { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens = new List<OrderItem>();
        public Cliente Cli = new Cliente();

        /* sugestao do Fernando   
           public List<OrderItem> Itens { get; set; }
           public Cliente Cli { get; set; }

           public Order()
           {
               Itens = new List<OrderItem>();
               Cli = new Cliente();
           }
        */

        public Order()
        {
            Momento = DateTime.Now;
        }

        public void addItem(OrderItem item)
        {
            Itens.Add(item);
        }
 
        public void removeItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public void setStatus(OrderStatus status)
        {
            Status = status;
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

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine("***  RESUMO DO POEDIDO  ***");
            SB.Append("Geração do pedido: ");
            SB.AppendLine(Momento.ToString("dd/MM/yy HH:mm:ss"));
            SB.Append("Situação do pedido: ");
            SB.AppendLine(Status.ToString());
            SB.Append("Cliente: ");
            SB.Append(Cli.Nome);
            SB.Append(" (");
            SB.Append(Cli.Aniversario.ToString("dd/MM/YY"));
            SB.Append(") - ");
            SB.AppendLine(Cli.Email);
            SB.AppendLine("Itens do Pedido:");
            foreach(OrderItem Item in Itens)
            {
                SB.Append(Item.P1.Nome);
                SB.Append(", ");
                SB.Append(Item.P1.Preco.ToString("F2"));
                SB.Append(", Quantidade: ");
                SB.Append(Item.Qtde.ToString());
                SB.Append(", Subtotal: ");
                SB.AppendLine(Item.SubTotal(Item.P1).ToString("F2"));
            }

            SB.Append("Valor total do Pedido: ");
            SB.AppendLine(Total().ToString("F2"));

            return SB.ToString();
        }
    }
}
