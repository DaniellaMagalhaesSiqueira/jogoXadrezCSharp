using System;
using tabuleiro;
using xadrez;

namespace JogoXadrez {
    class Tela {

        public static void imprimirTabuleiro(Tabuleiro tab) {
            ConsoleColor aux = Console.ForegroundColor;
            for (int i = 0; i < tab.linhas; i++) {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(8 - i + " ");
                Console.ForegroundColor = aux;
                for (int j = 0; j < tab.colunas; j++) {
                    imprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  A B C D E F G H");
            Console.ForegroundColor = aux;
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posPossiveis) {
            ConsoleColor aux = Console.ForegroundColor;
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.linhas; i++) {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(8 - i + " ");
                Console.ForegroundColor = aux;
                for (int j = 0; j < tab.colunas; j++) {
                    if (posPossiveis[i, j]) {
                        Console.BackgroundColor = fundoAlterado;
                    } else {
                        Console.BackgroundColor = fundoOriginal;

                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  A B C D E F G H");
            Console.ForegroundColor = aux;
            Console.BackgroundColor = fundoOriginal;
        }



        public static void imprimirPeca(Peca peca) {
            if (peca == null) {

                Console.Write("- ");

            } else {

                if (peca.cor == Cor.Branca) {
                    Console.Write(peca);
                } else {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }

        public static PosicaoXadrez lerPosicaoXadrez() {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
