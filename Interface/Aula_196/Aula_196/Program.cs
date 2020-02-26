using System;
using System.Globalization;
using Aula_196.Entities;
using Aula_196.Service;

namespace Aula_196
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do CONTRATO ");
            Console.Write("Numero: ");
            int numContrato = int.Parse(Console.ReadLine());
            Console.Write("Data do contrato (dd/MM/yyyy): ");
            DateTime dtContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor total do contrato: ");
            double valContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a quantidade de parcelas: ");
            int parcela = int.Parse(Console.ReadLine());

            Contrato myContrato = new Contrato(numContrato, dtContrato, valContrato);

            ContratoParcela contratoParcela = new ContratoParcela(new Paypal());
            contratoParcela.ProcessaContrato(myContrato, parcela);

            Console.WriteLine("Parcelas:");
            foreach (Parcela install in myContrato.Parcelas)
            {
                Console.WriteLine(install);
            }
        }
    }
}
