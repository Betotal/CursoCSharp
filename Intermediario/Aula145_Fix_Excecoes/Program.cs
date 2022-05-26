using System;
using Aula145_Fix_Excecoes.Entities;
using Aula145_Fix_Excecoes.Entities.Excecoes;

namespace Aula145_Fix_Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            char resposta = 'S';
            do
            {
                Console.WriteLine("*****     CONTA BANCARIA COM EXCECOES     *****");
                Console.WriteLine();
                try
                {
                    Console.Write("Ente com o número da conta: ");
                    int conta = int.Parse(Console.ReadLine());

                    Console.Write("Entre com o nome do Cliente: ");
                    string nome = Console.ReadLine();

                    Console.Write("Saldo inicial: ");
                    double saldoinicial = double.Parse(Console.ReadLine());

                    Console.Write("Limite de saque: ");
                    double limite = double.Parse(Console.ReadLine());

                    ContaBancaria Conta = new ContaBancaria(conta, nome, saldoinicial, limite);

                    Console.WriteLine();

                    Console.Write("Digite a quantia de saque: ");
                    Conta.Saque(double.Parse(Console.ReadLine()));

                    Console.WriteLine("Saldo atual: $ " + Conta.Saldo.ToString("F2"));

                }
                catch(DomainException e)
                {
                    Console.WriteLine("Erro no saque: " + e.Message);
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Erro de formatação: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                }
                finally
                {
                    Console.WriteLine();
                    Console.Write("Deseja entrar com novos dados? (s/n)");
                    resposta = char.Parse(Console.ReadLine());
                    if (resposta == 's' || resposta == 'S')
                        Console.Clear();
                }
            } while (resposta == 'S' || resposta == 's');
            Console.WriteLine("Hello World!");
        }
    }
}
