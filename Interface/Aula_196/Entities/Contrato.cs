using System;
using System.Collections.Generic;
<<<<<<< HEAD:Interface/Aula_196/Entities/Contrato.cs
=======

>>>>>>> 3aad5c9468bf2c7b282b100811072f9d30221962:Interface/Aula_196/Aula_196/Entities/Contrato.cs
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
