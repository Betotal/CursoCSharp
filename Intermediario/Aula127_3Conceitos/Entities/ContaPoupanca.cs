using System;
using System.Collections.Generic;
using System.Text;

namespace Aula127_3Conceitos.Entities
{

   // sealed class ContaPoupanca : ContaCorrente  // selando para que não seja herdada
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
       // public sealed override void RetiradaSaldo(double quantia) // selado para que o método não seja sobreposto
        public sealed override void RetiradaSaldo(double quantia) // selado para que o método não seja sobreposto
        {
            //Saldo -= quantia;
            base.RetiradaSaldo(quantia);
            Saldo -= 2.0;
        }
    }
}
