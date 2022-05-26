<<<<<<< HEAD
﻿
namespace Aula_191.Services {
    class TaxaBrasil : ITaxaServico {
        public double Taxa(double quantia) {
            return (quantia <= 100.00) ? quantia * 0.2 : quantia * 0.15;
        }
    }
}
=======
﻿
namespace Aula_191.Services {
    //class TaxaBrasil               // sem interface
    class TaxaBrasil : ITaxaServico      // com interface
        {
            public double Taxa(double quantia) {
            return (quantia <= 100.00) ? quantia * 0.2 : quantia * 0.15;
        }
    }
}
>>>>>>> 3aad5c9468bf2c7b282b100811072f9d30221962
