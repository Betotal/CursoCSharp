using System;
using System.Collections.Generic;

namespace Exerc_Aula78_List {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("**********     1ª utilização de lista     *********");

            Console.Write("Informe a Quantidade de Funcinários: "); int qtde = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Funcionario> Lista = new List<Funcionario>();

            int j, id;
            string nome;
            double salario;
            for (int i = 0; i < qtde; i++) {
                j = i + 1;
                Console.Write($"Informe o Id do trabalhador {j}: ");
                id = int.Parse(Console.ReadLine());
                Console.Write($"Informe o Nome do trabalhador {j}: ");
                nome = Console.ReadLine();
                Console.Write($"Informe o Salario do trabalhador {j}: ");
                salario = double.Parse(Console.ReadLine());

                Lista.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }
            Console.WriteLine("Lista de Trabalhadores:");
            foreach (Funcionario obj in Lista) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            Console.Write("Informe o Id do trabalhador que será Aumentado: "); id = int.Parse(Console.ReadLine());

            if (Lista.Exists(x => x.IdFunc == id)){ 
                int indice = Lista.FindIndex(x => x.IdFunc == id);
                Console.Write("Informe o indice de aumento: ");
                int aumento = int.Parse(Console.ReadLine());
                Lista[indice].AlteraSalario(aumento);
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("Lista de Trabalhadores atualizada:");
            foreach (Funcionario obj in Lista) {
                Console.WriteLine(obj);
            }
        }
        }
    }

