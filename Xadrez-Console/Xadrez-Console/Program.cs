using System;
using Tabuleiro_Pasta;
using Xadrez;

namespace Xadrez_Console {
    class Program {
        static void Main(string[] args) {
            try {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.terminada) {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();

                    partida.executaMovimento(origem, destino);

                }
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
