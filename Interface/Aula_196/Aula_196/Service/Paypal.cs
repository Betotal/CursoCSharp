namespace Aula_196.Service
{
    class Paypal:PagtoOnline
    {
        private const double Juros = 0.01;
        private const double Taxa = 0.02;

        public double ValPagto(double quantia, int numParcela)
        {
            return quantia * Juros * numParcela;
        }

        public double PagtoJuros(double quantia)
        {
            return quantia * Taxa;
        }
    }
}
