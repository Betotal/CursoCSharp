
namespace Aula125_Heranca.Entities
{
    class Conta
    {
        public int NumConta { get; private set; }
        public string Titular { get; private set; }     // set somente na classe
        public double Saldo { get; protected set; }     // set somente na classe e subclasse

        public Conta()
        {
        }

        public Conta(int numConta, string titular, double saldo)
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
