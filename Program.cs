using System;

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