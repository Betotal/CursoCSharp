using System;
using System.Collections.Generic;
using System.Text;

namespace Aula127_3Conceitos.Entities
{
    class ContaEspecial : ContaCorrente
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEspecial()
        {
        }

        public ContaEspecial(int numConta, string titular, double saldo, double limiteEmprestimo)
               : base(numConta, titular, saldo)  /* herança - Como a classe ContaJuridica herda tudo da classe "PAI", 
                                                              basta invocar a método : base e
                                                              usar as propriedades da classe "PAI"  */
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double quantia)
        {
            if (quantia <= LimiteEmprestimo)
            {
                Saldo += quantia;
            }
        }

    }
}
