using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Fix {
    class Aluno {

        public String Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double NotaFinal;
        
        public double CalculoFinal() {
            return NotaFinal = Nota1 + Nota2 + Nota3;
        }
        
        public string Situacao() {
            if (CalculoFinal() >= 60) {
                return "Aprovado!";
            } else {
                return "Reprovado!";
            } 
        }
        public double NotaFaltante() {
            return 60 - NotaFinal;
        }

    }
}

