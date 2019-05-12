using Tabuleiro_Pasta;

namespace Xadrez {
    class Peao : Peca {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }
        public override string ToString() {
            return "P";
        }

        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        private bool existeAdversario(Posicao pos) {
            Peca p = tab.peca(pos);
            return p != null && p.cor != cor;
        }
        private bool livre(Posicao pos) {
            return tab.peca(pos) == null;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] auxMatriz = new bool[tab.linhas, tab.colunas];

            //teste de movimento
            Posicao pos = new Posicao(0, 0);

            if (cor == Cor.Branco) {
                pos.definirValor(posicao.linha - 1, posicao.coluna);
                if (tab.posicaoValida(pos) && livre(pos)) {
                    auxMatriz[pos.linha, pos.coluna] = true;
                }
                pos.definirValor(posicao.linha - 2, posicao.coluna);
                if (tab.posicaoValida(pos) && livre(pos) && qtdMovto == 0) {
                    auxMatriz[pos.linha, pos.coluna] = true;
                }
                pos.definirValor(posicao.linha - 1, posicao.coluna - 1);
                if (tab.posicaoValida(pos) && existeAdversario(pos)) {
                    auxMatriz[pos.linha, pos.coluna] = true;
                }
                pos.definirValor(posicao.linha - 1, posicao.coluna + 1);
                if (tab.posicaoValida(pos) && existeAdversario(pos)) {
                    auxMatriz[pos.linha, pos.coluna] = true;
                }
            } else {
                pos.definirValor(posicao.linha + 1, posicao.coluna);
                if (tab.posicaoValida(pos) && livre(pos)) {
                    auxMatriz[pos.linha, pos.coluna] = true;
                }
                pos.definirValor(posicao.linha + 2, posicao.coluna);
                if (tab.posicaoValida(pos) && livre(pos) && qtdMovto == 0) {
                    auxMatriz[pos.linha, pos.coluna] = true;
                }
                pos.definirValor(posicao.linha + 1, posicao.coluna - 1);
                if (tab.posicaoValida(pos) && existeAdversario(pos)) {
                    auxMatriz[pos.linha, pos.coluna] = true;
                }
                pos.definirValor(posicao.linha + 1, posicao.coluna + 1);
                if (tab.posicaoValida(pos) && existeAdversario(pos)) {
                    auxMatriz[pos.linha, pos.coluna] = true;
                }
            }
            return auxMatriz;
        }
    }
}
