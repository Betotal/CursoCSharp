using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            /*   Programa Base
            
               Produto p = new Produto();
               Console.WriteLine("Entre os dados do produto:");
               Console.Write("Nome: "); p.Nome = Console.ReadLine();
               Console.Write("Preço: "); p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               Console.Write("Quantidade no estoque: "); p.Quantidade = int.Parse(Console.ReadLine());
               
            /* Melhoria Construtor  

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: "); string nome = Console.ReadLine();
            Console.Write("Preço: "); double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         //   Console.Write("Quantidade no estoque: "); int qtde = int.Parse(Console.ReadLine());

        //    Produto p = new Produto(nome, preco, qtde);

         /*   Sobrecarga no construtor     
            Produto p = new Produto(nome, preco);

            /*   Sintaxe Alternativa    
            Produto p3 = new Produto {
                Nome = "TV LED",
                Preco = 1090.00,
                Quantidade = 20
            };

            /* Base 
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: "); int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: "); qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);  */

            Produto p3 = new Produto ("TV LED", 1090.00, 20);
            Console.WriteLine(p3.Nome);
            Console.WriteLine();

            //   p3.Nome = "MITSUBISHI";
               p3.Nome = "M";
            Console.WriteLine(p3.Nome);
            Console.WriteLine(p3.Preco);
            Console.WriteLine(p3.Quantidade);

        }
    }
}