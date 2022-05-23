using System.Globalization;

namespace Aula_191.Entities {
    class Nota {

        public double PgtoBasico { get; set; }
        public double Taxa { get; set; }

        public Nota(double pgtoBasico, double taxa) {
            PgtoBasico = pgtoBasico;
            Taxa = taxa;
        }

        public double PagtoTotal {
            get { return PgtoBasico + Taxa; }
        }

        public override string ToString() {
            return "Pagamento Básico: " +
                   PgtoBasico.ToString("F2") +
                   "\nTaxa: " +
                   Taxa.ToString("F2") +
                   "\nPagamento Total: " +
                   PagtoTotal.ToString("F2");
        }
    }
}
