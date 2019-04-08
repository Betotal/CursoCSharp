using System;
using Aula122_Enum_Comp_StrBD.Entities;

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
                Console.WriteLine("Dados do Cliente:");
                Console.Write("Nome do Cliente: ");
                string nome = Console.ReadLine();

                Console.Write("Email do cliente: ");
                string email = Console.ReadLine();

                Console.Write("Data de Nascimento (DD/MM/AAAA): ");
                DateTime aniversario = DateTime.Parse(Console.ReadLine());

                Cliente client = new Cliente(nome, email, aniversario);
                Console.WriteLine();

                Console.WriteLine("Entre com os dados do Pedido:");

                Console.Write("Stutus do pedido(Pgto_Pendente/ Processando/ Enviado/ Entregue): ");
                string status = Console.ReadLine();

                Console.Write("Quantos itnes o pedido terá: ");
                int N = int.Parse(Console.ReadLine());
                
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine($"Entre com o dados do {i + 1}# Item");
                    Console.Write("Nome do produto: ");
                    string produto = Console.ReadLine();

                    Console.Write("Preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());

                    Console.Write("Quantidade do produto: ");
                    int qtde = int.Parse(Console.ReadLine());

                    OrderItem item = new OrderItem();

                    item.addOrderItem(qtde, produto, preco);
                }











            }while (resposta = 's' || resposta = 'S')
        }
    }
}
