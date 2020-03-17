using GameTOP.Interface;

namespace GameTOP
{
    public class jogoFODA
    {
        private readonly iJogador NomeJogadorA;
        private readonly iJogador NomeJogadorB;

        public jogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            NomeJogadorA = jogadorA;
            NomeJogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.WriteLine(NomeJogadorA.Chuta());
            System.Console.WriteLine(NomeJogadorA.Corre());
            System.Console.WriteLine(NomeJogadorA.Passe());

            System.Console.Write("\n Proximo Jogador \n");

            System.Console.WriteLine(NomeJogadorB.Chuta());  
            System.Console.WriteLine(NomeJogadorB.Corre());
            System.Console.WriteLine(NomeJogadorB.Passe());
        }
    }
}