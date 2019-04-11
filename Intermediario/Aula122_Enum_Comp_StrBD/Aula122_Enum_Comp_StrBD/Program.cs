using System;
using System.Collections.Generic;
using Aula122_Enum_Comp_StrBD.Entities;
using Aula122_Enum_Comp_StrBD.Enums;

namespace Aula122_Enum_Comp_StrBD
{
    class Program
    {
        static void Main(string[] args)
        {
            char resposta;

            Console.WriteLine("*****   Exercicio Emum, Composi e StringBuilder   *****");
            Console.WriteLine();
            Console.WriteLine();

            do
            {    
                Order Pedido = new Order();

                Console.WriteLine("DADOS DO CLIENTE:");
                Console.Write("                   Nome do Cliente: ");
                Pedido.Cli.Nome = Console.ReadLine();

                Console.Write("                   Email do cliente: ");
                Pedido.Cli.Email = Console.ReadLine();

                Console.Write("                   Data de Nascimento (DD/MM/AAAA): ");
                Pedido.Cli.Aniversario = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Entre com os dados do Pedido:");

                Console.Write("Status do pedido(Pgto_Pendente/ Processando/ Enviado/ Entregue): ");

             /*   string status = Console.ReadLine();
                OrderStatus os = new OrderStatus();
                switch (status)
                {
                    case "Pgto_Pendente":
                        os = Enum.OrderStatus.Pgto_Pendente;
                        break;
                    case "Processando":
                        os = Enum.OrderStatus.Processando;
                        break;
                    case "Enviado":
                        os = Enum.OrderStatus.Enviado;
                        break;
                    case "Entregue":
                        os = Enum.OrderStatus.Entregue;
                        break;
                    default:
                        break;
                }*/// Estava errado por causa da nomenclatura da pasta

                OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine()); 

                Pedido.setStatus(os);

                Console.Write("Quantos itens o pedido terá: ");
                int N = int.Parse(Console.ReadLine());

                List<OrderItem> Itens = new List<OrderItem>();

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine($"Entre com o dados do {i + 1}# Item");
                    Console.Write("Nome do produto: ");
                    string produto = Console.ReadLine();

                    Console.Write("Preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());

                    Console.Write("Quantidade do produto: ");
                    int qtde = int.Parse(Console.ReadLine());

                    Pedido.addItem(new OrderItem(qtde, produto, preco));
                    Console.WriteLine();
                }

                Console.WriteLine(Pedido);
                Console.WriteLine();
                
                Console.WriteLine("Deseja processar outro pedido? <S/N>: ");
                resposta = char.Parse(Console.ReadLine());

            } while (resposta == 's' || resposta == 'S');


        }
    }
}
