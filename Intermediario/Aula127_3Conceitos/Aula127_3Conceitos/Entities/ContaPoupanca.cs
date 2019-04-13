using System;
using System.Collections.Generic;
using System.Text;

namespace Aula127_3Conceitos.Entities
{
    class ContaPoupanca : ContaCorrente
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

        //sobreposicao 
        public override void RetiradaSaldo(double quantia)
        {
            //Saldo -= quantia;
            base.RetiradaSaldo(quantia);
            Saldo -= 2.0;
        }
    }
}
