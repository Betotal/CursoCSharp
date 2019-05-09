
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

        public void Movimento() {
            qtdMovto++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
