using System;
using Tabuleiro_Pasta;
using Xadrez;

namespace Xadrez_Console {
    class Program {
        static void Main(string[] args) {
            try {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(2, 4));

                tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(4, 0));
                tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(5, 3));
                tab.colocarPeca(new Rei(tab, Cor.Branco), new Posicao(7, 4));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
