using System;
using Aula135_Abstract.Entities.Emums;

namespace Aula135_Abstract.Entities
{
    class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(double raio, Cor color, TipoFigura tipof) : base(color, tipof)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2); 
        }
    }
}
