using System;
using Tabuleiro_Pasta;

namespace Xadrez {
    class PartidaXadrez {

        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaXadrez() {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branco;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino) {
            Peca p = tab.retirarPeca(origem);
            p.Movimento();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);

        }

        private void colocarPecas() {
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('C', 1).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('C', 2).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('D', 2).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('E', 2).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('E', 1).ToPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branco), new PosicaoXadrez('D', 1).ToPosicao());
            
            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('C', 7).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('C', 8).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('D', 7).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('E', 7).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('E', 8).ToPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preto), new PosicaoXadrez('D', 8).ToPosicao());
        }
    }
}
