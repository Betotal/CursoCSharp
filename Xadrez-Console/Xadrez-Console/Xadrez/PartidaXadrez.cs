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
        public Peca enPassant { get; private set; }

        public PartidaXadrez() {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branco;
            terminada = false;
            xeque = false;
            enPassant = null;
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

            // JogadaEspecial
            // Roque pequeno
            if (p is Rei && destino.coluna == origem.coluna + 2) {
                Posicao origemTorre = new Posicao(origem.linha, origem.coluna + 3);
                Posicao destinoTorre = new Posicao(origem.linha, origem.coluna + 1);
                Peca TorreRoque = tab.retirarPeca(origemTorre);
                TorreRoque.addMovimento();
                tab.colocarPeca(TorreRoque, destinoTorre);
            }
            // Roque pequeno
            if (p is Rei && destino.coluna == origem.coluna - 2) {
                Posicao origemTorre = new Posicao(origem.linha, origem.coluna - 4);
                Posicao destinoTorre = new Posicao(origem.linha, origem.coluna - 1);
                Peca TorreRoque = tab.retirarPeca(origemTorre);
                TorreRoque.addMovimento();
                tab.colocarPeca(TorreRoque, destinoTorre);
            }

            // jogada especial En Passant
            if (p is Peao) {
                if(origem.coluna != destino.coluna && pecaCapturada == null) {
                    Posicao posP;
                    if (p.cor == Cor.Branco) {
                        posP = new Posicao(destino.linha + 1, destino.coluna);
                    } else {
                        posP = new Posicao(destino.linha - 1, destino.coluna);
                    }
                    pecaCapturada = tab.retirarPeca(posP);
                    capturadas.Add(pecaCapturada);
                }
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

            // JogadaEspecial
            // Roque pequeno
            if (p is Rei && destino.coluna == origem.coluna + 2) {
                Posicao origemTorre = new Posicao(origem.linha, origem.coluna + 3);
                Posicao destinoTorre = new Posicao(origem.linha, origem.coluna + 1);
                Peca TorreRoque = tab.retirarPeca(destinoTorre);
                TorreRoque.subtractMovimento();
                tab.colocarPeca(TorreRoque, origemTorre);
            }
            // Roque pequeno
            if (p is Rei && destino.coluna == origem.coluna - 2) {
                Posicao origemTorre = new Posicao(origem.linha, origem.coluna - 4);
                Posicao destinoTorre = new Posicao(origem.linha, origem.coluna - 1);
                Peca TorreRoque = tab.retirarPeca(destinoTorre);
                TorreRoque.subtractMovimento();
                tab.colocarPeca(TorreRoque, origemTorre);
            }

            // jogada especial En Passant
            if(p is Peao) {
                if (origem.coluna != destino.coluna && pecaCapturada == enPassant) {
                    Peca peao = tab.retirarPeca(destino);
                    Posicao posP;
                    if (p.cor == Cor.Branco) {
                        posP = new Posicao(3, destino.coluna);
                    } else {
                        posP = new Posicao(4, destino.coluna);
                    }
                    tab.colocarPeca(peao, posP);
                }
            }
        }

        public void realizaJogada(Posicao origem, Posicao destino) {
            Peca pecaCapturada = executaMovimento(origem, destino);
            if (estaEmXeque(jogadorAtual)) {
                desfazMovimento(origem, destino, pecaCapturada);
                throw new TabuleiroException("Você não pode se colocar em Xeque!");
            }
            Peca p = tab.peca(destino);

            // Jogada especial Promocao
            if (p is Peao) {
                promocaoPeao(p, destino);
            }

            xeque = (estaEmXeque(adversario(jogadorAtual))) ? true : false;
            if (testeXequemate(adversario(jogadorAtual))) {
                terminada = true;
            } else {
                turno++;
                mudaJogador();
            }
            // Jogada especial Enpassant
            enPassant = ((p is Peao && (destino.linha == origem.linha - 2 || destino.linha == origem.linha + 2))) ? p : null;
        }

        private void promocaoPeao(Peca p, Posicao destino) {
            if ((p.cor == Cor.Branco && destino.linha == 0) || (p.cor == Cor.Preto && destino.linha == 7)) {
                p = tab.retirarPeca(destino);
                pecas.Remove(p);

                System.Console.Write("Selecione a peça para promoção(D >> Dama/ B >> Bispo/ T >> Torre/ C >> Cavalo):");
                char promo = char.Parse(System.Console.ReadLine().ToUpper());
                Peca newP = null;
                switch (promo) {
                    case 'D':
                        newP = new Dama(tab, p.cor);
                        break;
                    case 'B':
                        newP = new Bispo(tab, p.cor);
                        break;
                    case 'T':
                        newP = new Torre(tab, p.cor);
                        break;
                    case 'C':
                        newP = new Cavalo(tab, p.cor);
                        break;
                }
                tab.colocarPeca(newP, destino);
                pecas.Add(newP);
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
            if (!tab.peca(origem).movimentoPossivel(destino)) {
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
            colocarNovaPeca('A', 1, new Torre (tab, Cor.Branco));
            colocarNovaPeca('B', 1, new Cavalo(tab, Cor.Branco));
            colocarNovaPeca('C', 1, new Bispo (tab, Cor.Branco));
            colocarNovaPeca('D', 1, new Dama(tab, Cor.Branco));
            colocarNovaPeca('E', 1, new Rei(tab, Cor.Branco, this));
            colocarNovaPeca('F', 1, new Bispo (tab, Cor.Branco));
            colocarNovaPeca('G', 1, new Cavalo (tab, Cor.Branco));
            colocarNovaPeca('H', 1, new Torre (tab, Cor.Branco));
            colocarNovaPeca('A', 2, new Peao(tab, Cor.Branco, this));
            colocarNovaPeca('B', 2, new Peao(tab, Cor.Branco, this));
            colocarNovaPeca('C', 2, new Peao(tab, Cor.Branco, this));
            colocarNovaPeca('D', 2, new Peao(tab, Cor.Branco, this));
            colocarNovaPeca('E', 2, new Peao(tab, Cor.Branco, this));
            colocarNovaPeca('F', 2, new Peao(tab, Cor.Branco, this));
            colocarNovaPeca('G', 2, new Peao(tab, Cor.Branco, this));
            colocarNovaPeca('H', 2, new Peao(tab, Cor.Branco, this));

            colocarNovaPeca('A', 8, new Torre(tab, Cor.Preto));
            colocarNovaPeca('B', 8, new Cavalo(tab, Cor.Preto));
            colocarNovaPeca('C', 8, new Bispo(tab, Cor.Preto));
            colocarNovaPeca('D', 8, new Dama(tab, Cor.Preto));
            colocarNovaPeca('E', 8, new Rei(tab, Cor.Preto, this));
            colocarNovaPeca('F', 8, new Bispo(tab, Cor.Preto));
            colocarNovaPeca('G', 8, new Cavalo(tab, Cor.Preto));
            colocarNovaPeca('H', 8, new Torre(tab, Cor.Preto));
            colocarNovaPeca('A', 7, new Peao(tab, Cor.Preto, this));
            colocarNovaPeca('B', 7, new Peao(tab, Cor.Preto, this));
            colocarNovaPeca('C', 7, new Peao(tab, Cor.Preto, this));
            colocarNovaPeca('D', 7, new Peao(tab, Cor.Preto, this));
            colocarNovaPeca('E', 7, new Peao(tab, Cor.Preto, this));
            colocarNovaPeca('F', 7, new Peao(tab, Cor.Preto, this));
            colocarNovaPeca('G', 7, new Peao(tab, Cor.Preto, this));
            colocarNovaPeca('H', 7, new Peao(tab, Cor.Preto, this));

        }
    }
}
