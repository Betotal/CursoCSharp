using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Aula60
{
    class ContaBancaria
    {
        public int NumConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

     /*   public ContaBancaria(int conta, string titular, double deposito)
        {
            NumConta = conta;
            Titular = titular;
            Saldo = deposito;
        }
        */
        public ContaBancaria(int conta, string titular) { 
            NumConta = conta;
            Titular = titular;
            Saldo = 0.0; // Por didatica esta movimentando, mas não é necessário
        }

        public ContaBancaria(int conta, string titular, double depositoInicial) : this(conta, titular) {
            Deposito(depositoInicial);
        }

        public void Deposito (double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo -= (valor + 5);
        }

        public override string ToString() {
            return "Conta "      + NumConta.ToString() +
                   ", Titular: " + Titular             +
                   ", Saldo: $ " + Saldo.ToString("F2");

        }
    }
}
