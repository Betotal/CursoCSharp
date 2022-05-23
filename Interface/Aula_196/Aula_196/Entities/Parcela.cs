using System;
using Aula_196.Entities;

namespace Aula_196.Entities
{
    class Parcela
    {
        public DateTime DtParcela { get; set; }
        public double ValParcela { get; set; }

        public Parcela(DateTime dtParcela, double valParcela)
        {
            DtParcela = dtParcela;
            ValParcela = valParcela;
        }

        public override string ToString(){
            return "Prestações: \n" +
                   "Data da Prestação: " +
                   DtParcela.ToString("dd/MM/yyyy") +
                   " - " + ValParcela.ToString("F2");
        }
    }
}
