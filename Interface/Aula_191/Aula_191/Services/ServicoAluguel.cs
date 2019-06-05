using System;
using Aula_191.Entities;

namespace Aula_191.Services {
    class ServicoAluguel {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        private TaxaBrasil _taxaBrasil = new TaxaBrasil();

        public ServicoAluguel(double precoHora, double precoDia) {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
        }

        public void ProcessaNota(Aluguel carroAlugado) {
            TimeSpan duracao = carroAlugado.Final.Subtract(carroAlugado.Inicio);

            double pagtoBasico = 0.0;
            pagtoBasico = (duracao.TotalHours <= 12)? PrecoHora * Math.Ceiling(duracao.TotalHours): PrecoDia * Math.Ceiling(duracao.TotalDays);

            double taxa = _taxaBrasil.Taxa(pagtoBasico);

            carroAlugado.Nota = new Nota(pagtoBasico, taxa);
        }
    }
}
