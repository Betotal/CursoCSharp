using System;
using Tabuleiro_Pasta;

namespace Xadrez {
    class PartidaXadrez {

        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual{ get; private set; }
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

        public void realizaJogada(Posicao origem, Posicao destino) {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validarPosicaoOrigem(Posicao pos) {
            if (tab.peca(pos) == null) {
                throw new TabuleiroException("Não existe peça na posição escolhida!");
            }
            if (jogadorAtual != tab.peca(pos).cor) {
                throw new TabuleiroException("A peça escolhida não é a sua!");
            }
            if (!tab.peca(pos).existeMovimentosPossiveis()) {
                throw new TabuleiroException("Não há movimentos possiveis para a peça de origem escolhida!");
            }
        }

        public void validarPosicaoDestino(Posicao origem, Posicao destino) {
            if (!tab.peca(origem).podeMover(destino)) {
                throw new TabuleiroException("Posição de destivo inválida!");
            }
        }

        private void mudaJogador() {
            jogadorAtual = (jogadorAtual == Cor.Branco) ? Cor.Preto : Cor.Branco;
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
