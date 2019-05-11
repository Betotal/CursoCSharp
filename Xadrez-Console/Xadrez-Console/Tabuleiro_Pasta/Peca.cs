
namespace Tabuleiro_Pasta {
    abstract class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovto { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovto = 0;
        }

        public void addMovimento() {
            qtdMovto++;
        }

        public void subtractMovimento() {
            qtdMovto++;
        }


        public bool existeMovimentosPossiveis() {
            bool[,] auxMatriz = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++) {
                for (int j = 0; j < tab.colunas; j++) {
                    if (auxMatriz[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMover(Posicao pos) {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
