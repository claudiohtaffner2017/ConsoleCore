using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador1: iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome)
        {
            _Nome = nome;
        }

        //chuta
        public string Chuta()
        {
            return $"{_Nome} esta chutando";
            
        }
        //corre
        public string Corre()
        {
            return $"{_Nome} esta correndo";  
        }
        //passe
        public string Passe()
        {
           return $"{_Nome} esta passando";
        }
        
    }
}