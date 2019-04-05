using System;

namespace Aula118_120_Composition.Entities
{
    class HoraContrato
    {
        public DateTime DataContrato { get; set; }
        public double ValorHora { get; set; }
        public int HorasContrato { get; set; }

        public HoraContrato()
        {
        }

        public HoraContrato(DateTime dataContrato, double valorHora, int horasContrato)
        {
            DataContrato = dataContrato;
            ValorHora = valorHora;
            HorasContrato = horasContrato;
        }

        public double ValorTotal()
        {
            return HorasContrato * ValorHora;
        }
    }

}
