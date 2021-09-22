using System;
using GameTop.lib;

namespace GameTop
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new JogoFODA(
                new Jogador1()
                ,new Jogador2()
                );
            teste.IniciarJogo();   

            //**************************************************************************************
            //Exemplo 2 - Mostrou como passar parametro para o construtor
            //**************************************************************************************
            //var teste = new JogoFoda("Ronaldo");
            //teste.IniciarJogo();   

            //**************************************************************************************
            //Exemplo 1 - Mostrou como instanciar o método de uma classe dentro de uma outra classe
            //**************************************************************************************
            //var teste = new JogoFoda();
            //teste.IniciarJogo();            
        }
    }

    //**************************************************************************************
    // Essa classe foi usada para exemplo1 e exemplo2
    //**************************************************************************************
    //class JogoFoda
    //{

        //**************************************************************************************
        //Exemplo 2 - Mostrou como passar parametro para o construtor
        //**************************************************************************************
        //private readonly string _NomeJogador;
        //
        //Quando não tem retorno é o construtor
        //public JogoFoda(string nome)
        //{
        //    _NomeJogador = nome;
        //}
        //
        //public void IniciarJogo()
        //{
        //    Console.WriteLine($"{_NomeJogador} 1 deu um passe");
        //}

        //**************************************************************************************
        //Exemplo 1 - Mostrou como instanciar o método de uma classe dentro de uma outra classe
        //**************************************************************************************
        //public void IniciarJogo()
        //{
        //    Console.WriteLine("Jogador 1 deu um passe");
        //}

    //}
}
