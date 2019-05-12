using System.Collections.Generic;
using Tabuleiro_Pasta;

namespace Xadrez {
    class PartidaXadrez {

        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
        public bool terminada { get; private set; }
        public bool xeque { get; private set; }
        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;

        public PartidaXadrez() {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branco;
            terminada = false;
            xeque = false;
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
            colocarPecas();
        }

        public Peca executaMovimento(Posicao origem, Posicao destino) {
            Peca p = tab.retirarPeca(origem);
            p.addMovimento();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
            if (pecaCapturada != null) {
                capturadas.Add(pecaCapturada);
            }
            return pecaCapturada;
        }

        public void desfazMovimento(Posicao origem, Posicao destino, Peca pecaCapturada) {
            Peca p = tab.retirarPeca(destino);
            p.subtractMovimento();
            if (pecaCapturada != null) {
                tab.colocarPeca(pecaCapturada, destino);
                capturadas.Remove(pecaCapturada);
            }
            tab.colocarPeca(p, origem);
        }

        public void realizaJogada(Posicao origem, Posicao destino) {
            Peca pecaCapturada = executaMovimento(origem, destino);
            if (estaEmXeque(jogadorAtual)) {
                desfazMovimento(origem, destino, pecaCapturada);
                throw new TabuleiroException("Você não pode se colocar em Xeque!");
            }

            xeque = (estaEmXeque(adversario(jogadorAtual))) ? true : false;
            if (testeXequemate(adversario(jogadorAtual))) {
                terminada = true;
            } else {
                turno++;
                mudaJogador();
            }
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

        public HashSet<Peca> pecasCapturadas(Cor cor) {
            HashSet<Peca> auxCj = new HashSet<Peca>();
            foreach (Peca p in capturadas) {
                if (p.cor == cor) {
                    auxCj.Add(p);
                }
            }
            return auxCj;
        }
        public HashSet<Peca> pecasEmJogo(Cor cor) {
            HashSet<Peca> auxCj = new HashSet<Peca>();
            foreach (Peca p in pecas) {
                if (p.cor == cor) {
                    auxCj.Add(p);
                }
            }
            auxCj.ExceptWith(pecasCapturadas(cor));
            return auxCj;
        }

        private Cor adversario(Cor cor) {
            return (cor == Cor.Preto) ? Cor.Branco : Cor.Preto;
        }

        private Peca rei(Cor cor) {
            foreach(Peca p in pecasEmJogo(cor)) {
                if (p is Rei) {
                    return p;
                }
            }
            return null;
        } 
        public bool estaEmXeque(Cor cor) {
            Peca R = rei(cor);
            if (R == null) {
                throw new TabuleiroException("Não tem Rei da cor " + cor + " no tabuleiro!");
            }
            foreach(Peca p in pecasEmJogo(adversario(cor))) {
                bool[,] auxMatriz = p.movimentosPossiveis();
                if (auxMatriz[R.posicao.linha, R.posicao.coluna]){
                    return true;    
                }
            }
            return false;
        }         

        public bool testeXequemate(Cor cor) {
            if (!estaEmXeque(cor)) {
                return false;
            }
            foreach(Peca p in pecasEmJogo(cor)) {
                bool[,] auxMatriz = p.movimentosPossiveis();
                for (int i = 0; i < tab.linhas; i++) {
                    for (int j = 0; j < tab.colunas; j++) {
                        if (auxMatriz[i, j]) {
                            Posicao origem = p.posicao;
                            Posicao destino = new Posicao(i, j);
                            Peca pecaCapturada = executaMovimento(origem, destino);
                            bool testeXeque = estaEmXeque(cor);
                            desfazMovimento(origem, destino, pecaCapturada);
                            if (!testeXeque) {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        public void colocarNovaPeca(char coluna, int linha, Peca peca) {
            tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).ToPosicao());
            pecas.Add(peca);
        }
        private void colocarPecas() {
            colocarNovaPeca('C', 1, new Torre(tab, Cor.Branco));
            colocarNovaPeca('C', 2, new Torre(tab, Cor.Branco));
            colocarNovaPeca('D', 2, new Torre(tab, Cor.Branco));
            colocarNovaPeca('E', 2, new Torre(tab, Cor.Branco));
            colocarNovaPeca('E', 1, new Torre(tab, Cor.Branco));
            colocarNovaPeca('D', 1, new Rei(tab, Cor.Branco));

            colocarNovaPeca('C', 7, new Torre(tab, Cor.Preto));
            colocarNovaPeca('C', 8, new Torre(tab, Cor.Preto));
            colocarNovaPeca('D', 7, new Torre(tab, Cor.Preto));
            colocarNovaPeca('E', 7, new Torre(tab, Cor.Preto));
            colocarNovaPeca('E', 8, new Torre(tab, Cor.Preto));
            colocarNovaPeca('D', 8, new Rei(tab, Cor.Preto));
        }
    }
}
