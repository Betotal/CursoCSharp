using System;
using System.Collections.Generic;
using System.Text;

namespace Aula127_3Conceitos.Entities
{
    class ContaCorrente
    {
        public int NumConta { get; private set; }
        public string Titular { get; private set; }     // set somente na classe
        public double Saldo { get; protected set; }     // set somente na classe e subclasse

        public ContaCorrente()
        {
        }

        public ContaCorrente(int numConta, string titular, double saldo)
        {
            NumConta = numConta;
            Titular = titular;
            Saldo = saldo;
        }

        //sobréposicao
        public virtual void RetiradaSaldo(double quantia)
        { 
            Saldo -= quantia - 5.00;
            
        }

        public void DepositoSaldo(double quantia)
        {
            Saldo += quantia;
        }


    }
}
