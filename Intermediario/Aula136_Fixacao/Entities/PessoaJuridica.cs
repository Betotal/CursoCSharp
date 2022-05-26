using Aula136_Fixacao.Entities;

namespace Aula136_Fixacao.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int QtdeFunc { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int qtdefunc) : base(nome, rendaAnual)
        {
            QtdeFunc = qtdefunc;
            Imposto = CalcImposto();
        }

        public override double CalcImposto()
        {
            return (QtdeFunc > 10) ? (RendaAnual * 14 / 100) : (RendaAnual * 16 / 100);
        }

    }
}
