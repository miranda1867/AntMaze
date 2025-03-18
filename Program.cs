using System;
//La clase Program sirve como el punto de entrada de la aplicación, inicializando el juego y comenzando el ciclo de juego
namespace AntMaze;
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.DisplayGameInfo();
            game.Play();
        }
    }