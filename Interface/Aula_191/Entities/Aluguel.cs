using System;

namespace Aula_191.Entities {
    class Aluguel {

        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }
        public Veiculo  Carro { get; set; }
        public Nota Nota { get; set; }

        public Aluguel(DateTime inicio, DateTime final, Veiculo carro) {
            Inicio = inicio;
            Final = final;
            Carro = carro;
            Nota = null;
        }
    }
}
