using Aula135_Abstract.Entities.Emums;

namespace Aula135_Abstract.Entities
{
    class Retangulo : Figura
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Cor color, TipoFigura tipof) : base(color, tipof)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
