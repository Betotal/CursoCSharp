﻿using System;
using Tabuleiro_Pasta;
using Xadrez;

namespace Xadrez_Console {
    class Program {
        static void Main(string[] args) {

            PosicaoXadrez pos = new PosicaoXadrez('A', 1);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());
            /*
            try {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(0, 0));


                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            */
            Console.ReadLine();

        }
    }
}
