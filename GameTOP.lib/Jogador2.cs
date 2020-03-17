using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradonas esta Chutando";
        }

        public string Corre()
        {
            return "Maradonas esta Correndo";
        }

        public string Passe()
        {
            return "Maradonas esta Passendo";
        }
    }

}