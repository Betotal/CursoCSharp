using System;
using System.Collections.Generic;
using System.Text;

namespace Aula122_Enum_Comp_StrBD.Entities
{
    class OrderItem
    {
        public int Qtde { get; set; }
        public Produto P1 = new Produto();
        
        public  OrderItem(int qtde, string nome, double preco)
        {
            Qtde = qtde;
            P1 = new Produto(nome, preco);
        }

        public double SubTotal(Produto P1)
        {
            return Qtde * P1.Preco;
        }
        // programa do professor
        public override string ToString()
        {
            return P1.Nome
                 + ", $"
                 + P1.Preco.ToString("F2")
                 + ", Quantidade: "
                 + Qtde.ToString()
                 + ", Subtotal: "
                 + SubTotal(P1).ToString("F2");
        }
    }
}
