using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_191.Services {
    class TaxaBrasil : ITaxaServico {
        public double Taxa(double quantia) {
            return (quantia <= 100.00) ? quantia * 0.2 : quantia * 0.15;
        }
    }
}
