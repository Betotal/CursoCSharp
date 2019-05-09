using Tabuleiro_Pasta;

namespace Xadrez {
    class Rei : Peca {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }
        public override string ToString() {
            return "R";
        }

        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
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
            return auxMatriz;
        }

    }
}
