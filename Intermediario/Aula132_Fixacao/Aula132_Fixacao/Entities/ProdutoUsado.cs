using System;

namespace Aula132_Fixacao.Entities
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string Etiqueta()
        {
            return Nome
                 + " (usado) $"
                 + Preco.ToString("F2")
                 + " (Data de fabricação: "
                 + DataFabricacao.ToString("dd/MM/yy")
                 + ")";
        }
    }
}
