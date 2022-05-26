using System;
using System.Collections.Generic;
using System.Text;

namespace Aula126_UpDownCast.Entities
{
    class ContaCorrente //: ContaCorrente
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

        public void RetiradaSaldo(double quantia)
        {
            Saldo -= quantia;
        }

        public void DepositoSaldo(double quantia)
        {
            Saldo += quantia;
        }

    }
}
