using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro {
    abstract class Peca {

        public Posicao posicao { get; set; }

        //pode ser acessada por outras classes,
        //mas só pode ser alterada por ela mesma e pelas subClasses
        public Cor cor { get; protected set; }

        public int qtdMovimentos { get; protected set; }

        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }

        public void incremetarMovimentos() {
            qtdMovimentos++;
        }

        public abstract bool[,] movimentosPossíveis();
    }
}
