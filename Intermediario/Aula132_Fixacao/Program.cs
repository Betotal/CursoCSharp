using System;
using System.Collections.Generic;
using Aula132_Fixacao.Entities;
using Aula132_Fixacao.Emums;

namespace Aula132_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****    HERANÇA E POLIMORFISMO     *****");
            Console.Write("Entre com a quantidade de produtos: ");
            int N = int.Parse(Console.ReadLine());

            List<Produto> Lista = new List<Produto>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Dados do produto {i}#: ");
                Console.Write("Nome do Produto: ");
                string nome = Console.ReadLine();

                Console.Write("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine());

                Console.Write("Tipo do Produto (Comum/Usado/Importado): ");
                TipoProduto tpp = Enum.Parse<TipoProduto>(Console.ReadLine());

                switch (tpp)
                {
                    case TipoProduto.Comum:
                        Lista.Add(new Produto(nome, preco));
                        break;

                    case TipoProduto.Usado:
                        Console.Write("Data de fabricação: ");
                        DateTime data = DateTime.Parse(Console.ReadLine());
                        Lista.Add(new ProdutoUsado(nome, preco, data));
                        break;

                    case TipoProduto.Importado:
                        Console.Write("Taxa de importação: ");
                        double taxa = double.Parse(Console.ReadLine());
                        Lista.Add(new ProdutoImport(nome, preco, taxa));
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("***   Etiquetas dos produtos   ***");
            foreach(Produto prd in Lista)
            {
                Console.WriteLine(prd.Etiqueta());
            }
        }
    }
}
