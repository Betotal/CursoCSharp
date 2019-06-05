using System;
using Aula_191.Entities;

namespace Aula_191.Services {
    class ServicoAluguel {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        private ITaxaServico _taxaServico;

        public ServicoAluguel(double precoHora, double precoDia, ITaxaServico taxaservico) {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            _taxaServico = taxaservico;
        }

        public void ProcessaNota(Aluguel carroAlugado) {
            TimeSpan duracao = carroAlugado.Final.Subtract(carroAlugado.Inicio);

            double pagtoBasico = 0.0;
            pagtoBasico = (duracao.TotalHours <= 12)? PrecoHora * Math.Ceiling(duracao.TotalHours): PrecoDia * Math.Ceiling(duracao.TotalDays);

            double taxa = _taxaServico.Taxa(pagtoBasico);

            carroAlugado.Nota = new Nota(pagtoBasico, taxa);
        }
    }
}
