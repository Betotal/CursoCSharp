using Tabuleiro_Pasta;

namespace Xadrez {
    class Rei : Peca {

        private PartidaXadrez partida;

        public Rei(Tabuleiro tab, Cor cor, PartidaXadrez partida) : base(tab, cor) {
            this.partida = partida;
        }
        public override string ToString() {
            return "R";
        }

        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        private bool testeTorreRoque(Posicao pos) {
            Peca p = tab.peca(pos);
            return p != null && p is Torre && p.cor == cor && p.qtdMovto == 0;
        }

        public override bool [,] movimentosPossiveis() {
            bool[,] auxMatriz = new bool[tab.linhas, tab.colunas];

         //teste de movimento
            Posicao pos = new Posicao(0, 0);

            
            // acima
            pos.definirValor(posicao.linha - 1, posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            // acima a direita
            pos.definirValor(posicao.linha - 1, posicao.coluna + 1  );
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            // direita
            pos.definirValor(posicao.linha, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            // abaixo a direita
            pos.definirValor(posicao.linha + 1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            // abaixo
            pos.definirValor(posicao.linha + 1, posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            // abaixo a esquerda
            pos.definirValor(posicao.linha + 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            // esquerda
            pos.definirValor(posicao.linha, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            // acima a esqeurda
            pos.definirValor(posicao.linha - 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            //  JogadaEspecial Roque
            if (qtdMovto == 0 && !partida.xeque) {
                // Roque Pequeno
                Posicao posTorre1 = new Posicao(posicao.linha, posicao.coluna + 3);
                if (testeTorreRoque(posTorre1)) {
                    Posicao P1 = new Posicao(posicao.linha, posicao.coluna + 1);
                    Posicao P2 = new Posicao(posicao.linha, posicao.coluna + 2);
                    if (tab.peca(P1) == null && tab.peca(P2) == null) {
                        auxMatriz[posicao.linha, posicao.coluna + 2] = true;
                    }
                }

                // Roque Grande
                Posicao posTorre2 = new Posicao(posicao.linha, posicao.coluna - 4);
                if (testeTorreRoque(posTorre2)) {
                    Posicao P1 = new Posicao(posicao.linha, posicao.coluna - 1);
                    Posicao P2 = new Posicao(posicao.linha, posicao.coluna - 2);
                    Posicao P3 = new Posicao(posicao.linha, posicao.coluna - 3);
                    if (tab.peca(P1) == null && tab.peca(P2) == null && tab.peca(P3) == null) {
                        auxMatriz[posicao.linha, posicao.coluna - 3] = true;
                    }
                }
            }
            return auxMatriz;
        }
    }
}
