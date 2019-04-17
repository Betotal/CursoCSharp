using System;
using Aula136_Fixacao.Entities;

namespace Aula136_Fixacao.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
            Imposto = CalcImposto();
        }

        public override double CalcImposto()
        {
            return (RendaAnual < 20000) ? ((RendaAnual * 15 / 100) - (GastoSaude/2)): ((RendaAnual * 25 / 100) - (GastoSaude / 2));
        }
    }
}
