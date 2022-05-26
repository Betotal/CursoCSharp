using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Fix {
    class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }  
        
        public double Primetro() {
            return (Largura * 2) + (Altura * 2);
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }
}