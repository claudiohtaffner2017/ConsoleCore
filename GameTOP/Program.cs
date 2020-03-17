using System;
using GameTOP.lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new jogoFODA(new Jogador1("claudio"), new Jogador2());
            jogo.IniciarJogo();
        }
    }




}
