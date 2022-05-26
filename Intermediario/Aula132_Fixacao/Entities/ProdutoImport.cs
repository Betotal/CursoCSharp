
namespace Aula132_Fixacao.Entities
{
    class ProdutoImport : Produto
    {
        public double TaxaImportacao { get; set; }

        public ProdutoImport()
        {
        }

        public ProdutoImport(string nome, double preco, double taxaImportacao) : base(nome, preco)
        {
            TaxaImportacao = taxaImportacao;
            Precototal();
        }

        public void Precototal()
        {
            Preco += TaxaImportacao;
        }

        public override string Etiqueta()
        {
            return base.Etiqueta()
                 + " (Taxa de importação: $"
                 + TaxaImportacao.ToString("F2")
                 + ")";
        }
    }
}
