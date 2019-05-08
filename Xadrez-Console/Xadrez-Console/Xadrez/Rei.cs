﻿using Tabuleiro_Pasta;

namespace Xadrez {
    class Rei : Peca {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }
        public override string ToString() {
            return "R";
        }

    }
}