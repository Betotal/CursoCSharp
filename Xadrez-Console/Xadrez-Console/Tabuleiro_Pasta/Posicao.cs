
namespace Tabuleiro_Pasta {
    class Posicao {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }

        // teste de movimento
        public void definirValor(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString() {
            return linha
                 + ", "
                 + coluna;
        }
    }
}
