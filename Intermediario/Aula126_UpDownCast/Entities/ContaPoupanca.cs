using System;
using System.Collections.Generic;
using System.Text;

namespace Aula126_UpDownCast.Entities
{
    class ContaPoupanca: ContaCorrente
    {
        public double TaxaUpdate { get; set; }

        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numConta, string titular, double saldo, double taxa) : base(numConta, titular, saldo)
        {

            TaxaUpdate = taxa;
        }

        public void AtualizaSaldo(double taxa)
        {
            Saldo += (1 + (taxa / 100));
        }
    }
}
