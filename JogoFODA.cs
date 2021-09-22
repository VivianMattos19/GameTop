using GameTop.Interface;

namespace GameTop
{
    public class JogoFODA
    {
        public readonly iJogador _jogadorA;

        public readonly iJogador _jogadorB;
        
        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            _jogadorA = jogador1;
            _jogadorB = jogador2;
        }

        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Passe());      

            System.Console.Write("\n PRÓXIMO JOGADOR \n\n");

            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Passe());           
        }
        //**********************************************
        //Exemplo 3 - Construtor recebe um tipo string
        //**********************************************
        //private readonly string _NomeJogador;
        
        //Quando não tem retorno é o construtor
        //public JogoFODA(string nome)
        //{
        //    _NomeJogador = nome;
        //}
        
        //public void IniciarJogo()
        //{
        //    System.Console.WriteLine($"{_NomeJogador} 1 deu um passe");
        //}
        
    }

     
}