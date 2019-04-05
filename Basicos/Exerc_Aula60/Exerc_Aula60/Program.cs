using System;

namespace Exerc_Aula60
{
    class Program
    {
        public static object Conta { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("************    ENCAPSULAMENTO DEPOSITO DA CONTA   *********");

            for (int I = 1; I <= 2; I++)
            {
                Console.WriteLine();
                Console.Write("Entre com os dados da conta: "); int numConta = int.Parse(Console.ReadLine());
                Console.Write("Entre com o nome do Titular da conta: "); string titular = Console.ReadLine();
                Console.Write("Haverá deposito inicial <S/N>: "); char resposta = char.Parse(Console.ReadLine());
                ContaBancaria ContaBanco;

                if (resposta == "s" || resposta == "S")
                {
                    Console.Write("Entre com o valor inicial de depósito: "); double deposito = double.Parse(Console.ReadLine());
                    ContaBanco = new ContaBancaria(numConta, titular, deposito);
                }
                else
                {
                    ContaBanco = new ContaBancaria(numConta, titular);
                }

                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(ContaBanco.ToString());
                Console.WriteLine();

                Console.Write("Entre com o valor de depósito: "); ContaBanco.Deposito(double.Parse(Console.ReadLine()));
                Console.WriteLine("Dados atualizados da conta: ");
                Console.WriteLine(ContaBanco.ToString());
                Console.WriteLine();

                Console.Write("Entre com o valor de Saque: "); ContaBanco.Saque(double.Parse(Console.ReadLine()));
                Console.WriteLine("Dados atualizados da conta: ");
                Console.WriteLine(ContaBanco.ToString());

                Console.WriteLine();
                Console.WriteLine();

            }
        }
    }
}
