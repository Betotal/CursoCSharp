using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Aula71_Array {
    class Quarto {

        public string Nome { get; private set; }
        public string Email { get; private set; }

       public Quarto( string _nome, string _email) {
           Nome = _nome;
           Email = _email;
       }
    }

}
