using System;
using System.Collections.Generic;
namespace Aula_196.Entities
{
    class Contrato
    {
        public int numContrato { get; set; }
        public DateTime dtContrato { get; set; }
        public double valContrato { get; set; }
        public List<Parcela> Parcelas { get; set; }

        public Contrato(int numContrato, DateTime dtContrato, double valContrato)
        {
            this.numContrato = numContrato;
            this.dtContrato = dtContrato;
            this.valContrato = valContrato;
            Parcelas = new List<Parcela>();
         }

        public void AddParcela(Parcela Parcela)
        {
            Parcelas.Add(Parcela);
        }
    }
}
