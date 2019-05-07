using Tabuleiro_Pasta;

namespace Xadrez {
    class PosicaoXadrez {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha) {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao ToPosicao() {
            return new Posicao(8 - linha, coluna - 'A');
        }

        public override string ToString() {
            return "" + coluna + linha;
        }
    }
}
