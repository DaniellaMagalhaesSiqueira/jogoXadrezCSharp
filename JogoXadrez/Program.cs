using System;
using tabuleiro;

namespace JogoXadrez {
    class Program {
        static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(12, 12);
            Console.WriteLine(tab.linhas + " _ " + tab.colunas);
        }
    }
}
