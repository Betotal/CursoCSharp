﻿using System;
using Tabuleiro_Pasta;
using Xadrez;

namespace Xadrez_Console {
    class Tela {

        public static void ImprimirTabuleiro(Tabuleiro tab) {
            for (int i = 0; i < tab.linhas; i++) {
                Console.Write(8 - i + " >> ");
                for (int j = 0; j < tab.colunas; j++) {
                    ImprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("     A B C D E F G H");
        }

        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] posicoesValidas) {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoPossivel = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++) {
                Console.Write(8 - i + " >> ");
                for (int j = 0; j < tab.colunas; j++) {
                    if (posicoesValidas[i, j]) {
                        Console.BackgroundColor = fundoPossivel;
                    } else {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    ImprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("     A B C D E F G H");
        }

        public static PosicaoXadrez lerPosicaoXadrez() {
            string s = Console.ReadLine().ToUpper();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void ImprimirPeca(Peca peca) {
            if (peca == null) {
                Console.Write("- ");
            } else {
                if (peca.cor == Cor.Branco) {
                    Console.Write(peca);
                } else {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
