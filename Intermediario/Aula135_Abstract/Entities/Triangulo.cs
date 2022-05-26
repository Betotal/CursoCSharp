using System;
using System.Collections.Generic;
using System.Text;
using Aula135_Abstract.Entities;
using Aula135_Abstract.Entities.Emums;

namespace Aula135_Abstract.Entities
{
    class Triangulo : Retangulo
    {
        public Triangulo(double largura, double altura, Cor color, TipoFigura tipof): base(largura, altura, color, tipof)
        {
            Altura = altura;
            Largura = largura;
        }
    
        public override double Area()
        {
            return base.Area() / 2;
        }
    }
}
