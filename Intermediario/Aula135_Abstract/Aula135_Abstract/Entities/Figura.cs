using Aula135_Abstract.Entities.Emums;

namespace Aula135_Abstract.Entities
{
    abstract class Figura
    {
        public Cor Color { get; set; }
        public TipoFigura TipoF { get; set; }

        public Figura(Cor color, TipoFigura tipof)
        {
            Color = color;
            TipoF = tipof;
        }

        public abstract double Area(); // método abstrato, obriga que a classe seja abstrata 
    }
}
