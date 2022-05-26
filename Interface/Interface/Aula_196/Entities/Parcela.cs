<<<<<<< HEAD:Interface/Aula_196/Entities/Parcela.cs
﻿using System;

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
=======
﻿using System;

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
>>>>>>> 3aad5c9468bf2c7b282b100811072f9d30221962:Interface/Interface/Aula_196/Entities/Parcela.cs
