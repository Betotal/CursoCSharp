﻿using Tabuleiro_Pasta;

namespace Xadrez {
    class Cavalo : Peca {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }
        public override string ToString() {
            return "C";
        }

        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] auxMatriz = new bool[tab.linhas, tab.colunas];

            //teste de movimento
            Posicao pos = new Posicao(0, 0);

            pos.definirValor(posicao.linha - 1, posicao.coluna - 2);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            pos.definirValor(posicao.linha - 1, posicao.coluna + 2);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            pos.definirValor(posicao.linha + 1, posicao.coluna - 2);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            pos.definirValor(posicao.linha + 1, posicao.coluna + 2);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            pos.definirValor(posicao.linha - 2, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            pos.definirValor(posicao.linha - 2, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            pos.definirValor(posicao.linha + 2, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }

            pos.definirValor(posicao.linha + 2, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                auxMatriz[pos.linha, pos.coluna] = true;
            }
            return auxMatriz;
        }

    }
}
