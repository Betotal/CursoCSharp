using Aula145_Fix_Excecoes.Entities.Excecoes;

namespace Aula145_Fix_Excecoes.Entities
{
    class ContaBancaria
    {
        public int Numero { get; set; }
        public string NomeCliente { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public ContaBancaria()
        {
        }

        public ContaBancaria(int numero, string nomeCliente, double saldo, double limiteSaque)
        {
            Numero = numero;
            NomeCliente = nomeCliente;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            if (quantia > Saldo)
            {
                throw new DomainException("Saldo insuficiente para saque");
            }
            if (quantia > LimiteSaque)
            {
                throw new DomainException("Saque excedeu limite de saque");
            }
            Saldo -= quantia; 
        }
    }
}
