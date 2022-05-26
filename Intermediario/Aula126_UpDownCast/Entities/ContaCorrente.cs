using System;
using System.Collections.Generic;
using System.Text;

namespace Aula126_UpDownCast.Entities
{
<<<<<<< HEAD:Intermediario/Aula126_UpDownCast/Entities/ContaCorrente.cs
    class ContaCorrente  //: ContaCorrente
=======
    class ContaCorrente //: ContaCorrente
>>>>>>> 3aad5c9468bf2c7b282b100811072f9d30221962:Intermediario/Aula126_UpDownCast/Aula126_UpDownCast/Entities/ContaCorrente.cs
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
