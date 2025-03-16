using System;
using System.Collections.Generic;

namespace AntMaze
{
    public class Game
    {
        private List<Player> players;
        private Maze maze;
        private int turn;

        public Game()
        {
            maze = new Maze(10, 10); // Crear un laberinto de 10x10
            maze.PrintMaze(); // Print the maze after initialization
            players = new List<Player>
            {
                new Player("Jugador 1"),
                new Player("Jugador 2")
            };

            // Asignar hormigas a los jugadores
            players[0].AddAnt(new Ant("Hormiga Roja de los Bosques", "Revelar parte del laberinto"));
            players[0].AddAnt(new Ant("Hormiga de Fuego Roja", "Movimiento extra"));
            players[1].AddAnt(new Ant("Hormiga Cortadora de Hojas", "Crear barrera"));
            players[1].AddAnt(new Ant("Hormiga Argentina", "Interrumpir turno del oponente"));
            players[1].AddAnt(new Ant("Hormiga Exploradora", "Invisibilidad temporal"));

            turn = 0;
        }

        public void DisplayGameInfo()
        {
            Console.WriteLine("¡Bienvenido al Juego del Laberinto de Hormigas!");
            Console.WriteLine("Controles del Juego:");
            Console.WriteLine("W - Mover Arriba");
            Console.WriteLine("A - Mover Izquierda");
            Console.WriteLine("S - Mover Abajo");
            Console.WriteLine("D - Mover Derecha");
            Console.WriteLine("G - Usar Habilidad de la Hormiga");
            Console.WriteLine("Objetivo:");
            Console.WriteLine("- Navegar tus hormigas a través del laberinto.");
            Console.WriteLine("- Evitar obstáculos y moverse hacia el hormiguero.");
            Console.WriteLine("- Usar las habilidades únicas de tus hormigas estratégicamente.");
            Console.WriteLine();
        }

        public void Play()
        {
            while (true)
            {
                Player currentPlayer = players[turn % players.Count];
                Console.WriteLine($"Turno {turn}: {currentPlayer.Name}");
                var random = new Random();

                foreach (var ant in currentPlayer.Ants)
                {
                    if (random.Next(10) < 3)
                    {
                        currentPlayer.UseAntSkill(ant.Name, maze); // Pasar el laberinto para aplicar la habilidad
                    }

                    Console.WriteLine($"Moviendo {ant.Name}. Elige dirección (W/A/S/D):");
                    var direction = Console.ReadKey().Key;
                    int newX = ant.X, newY = ant.Y;

                    switch (direction)
                    {
                        case ConsoleKey.W:
                            newX--;
                            break;
                        case ConsoleKey.A:
                            newY--;
                            break;
                        case ConsoleKey.S:
                            newX++;
                            break;
                        case ConsoleKey.D:
                            newY++;
                            break;
                        case ConsoleKey.G:
                            currentPlayer.UseAntSkill(ant.Name, maze);
                            break;
                        default:
                            Console.WriteLine("¡Dirección inválida!");
                            continue;
                    }
                    maze.MoveAnt(ant, newX, newY);
                    maze.PrintMaze(); // Print the maze after each move
                }

                currentPlayer.ReduceCooldowns();
                turn++;
            }
        }
    }
}

