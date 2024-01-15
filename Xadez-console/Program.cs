﻿using System;
using tabuleiro;
using xadrez;

namespace Xadez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
            tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(1, 3));
            tab.colocarPeca(new Torre(tab, Cor. Branco), new Posicao(6, 5));
            tab.colocarPeca(new Rei(tab, Cor.Branco), new Posicao(7, 7));

            Tela.imprimirTabuleiro(tab);

            Console.WriteLine();
        }
    }
}
