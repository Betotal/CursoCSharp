using Tabuleiro_Pasta;

namespace Xadrez {
    class Peao : Peca {
        private PartidaXadrez partida;

        public Peao(Tabuleiro tab, Cor cor, PartidaXadrez partida) : base(tab, cor) {
            this.partida = partida;
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

                // jogada especial EnPassant
                if (posicao.linha == 3) {
                    Posicao esquerda = new Posicao(posicao.linha, posicao.coluna - 1);
                    if (tab.posicaoValida(esquerda) && existeAdversario(esquerda) && tab.peca(esquerda) == partida.enPassant) {
                        auxMatriz[esquerda.linha - 1, esquerda.coluna] = true;
                    }

                    Posicao direita = new Posicao(posicao.linha, posicao.coluna + 1);
                    if (tab.posicaoValida(direita) && existeAdversario(direita) && tab.peca(direita) == partida.enPassant) {
                        auxMatriz[direita.linha - 1, direita.coluna] = true;
                    }
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
                // jogada especial EnPassant
                if (posicao.linha == 4) {
                    Posicao esquerda = new Posicao(posicao.linha, posicao.coluna - 1);
                    if (tab.posicaoValida(esquerda) && existeAdversario(esquerda) && tab.peca(esquerda) == partida.enPassant) {
                        auxMatriz[esquerda.linha + 1, esquerda.coluna] = true;
                    }

                    Posicao direita = new Posicao(posicao.linha, posicao.coluna - 1);
                    if (tab.posicaoValida(direita) && existeAdversario(direita) && tab.peca(direita) == partida.enPassant) {
                        auxMatriz[direita.linha + 1, direita.coluna] = true;
                    }
                }

            }
            return auxMatriz;
        }
    }
}
