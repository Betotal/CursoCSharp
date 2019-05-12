using Tabuleiro_Pasta;

namespace Xadrez {
    class Dama : Peca {
        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }
        public override string ToString() {
            return "D";
        }

        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] auxMatriz = new bool[tab.linhas, tab.colunas];

            //teste de movimento
            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValor(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            //abaixo
            pos.definirValor(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            //direita
            pos.definirValor(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }

            //esquerda
            pos.definirValor(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }

            // acima a direita
            pos.definirValor(posicao.linha - 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValor(pos.linha - 1, pos.coluna + 1);
            }

            // abaixo a direita
            pos.definirValor(posicao.linha + 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValor(pos.linha + 1, pos.coluna + 1);
            }

            // abaixo a esquerda
            pos.definirValor(posicao.linha + 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValor(pos.linha + 1, pos.coluna - 1);
            }

            // acima a esquerda
            pos.definirValor(posicao.linha - 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValor(pos.linha - 1, pos.coluna - 1);
            }


            return auxMatriz;
        }
    }
}