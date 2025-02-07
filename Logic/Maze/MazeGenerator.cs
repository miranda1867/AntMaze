using System;
using System.Collections.Generic;

namespace AntMaze
{
    public class MazeGenerator
    {
        private int width, height;
        private bool[,] maze;
        private Random rnd = new Random();

        // Constructor de la clase MazeGnerator
        public MazeGenerator(int width, int height)
        {
            this.width = width; 
            this.height = height;
            maze = new bool[width, height];
        }

        // Metodo para generar el laberinto usando el algoritmo de Prim
        public bool[,] GenerateMaze()
        {
            // Initialize maze with walls
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    maze[x, y] = true; // True represents a wall
                }
            }

            // Start from a random point in the maze
            int startX = rnd.Next(width);
            int startY = rnd.Next(height);

            maze[startX, startY] = false; // False represents a path
            List<Tuple<int, int>> walls = new List<Tuple<int, int>> { new Tuple<int, int>(startX, startY) };

            while (walls.Count > 0)
            {
                int wallIndex = rnd.Next(walls.Count);
                var wall = walls[wallIndex];
                walls.RemoveAt(wallIndex);

                int x = wall.Item1;
                int y = wall.Item2;

                if (IsPartOfPath(x, y))
                {
                    maze[x, y] = false; // Create a path in the maze
                    AddWalls(x, y, walls); // Add neighboring walls to the list
                }
            }
            return maze;
        }

        // Check if the cell is part of the maze's path
        private bool IsPartOfPath(int x, int y)
        {
            int count = 0;
            if (x > 0 && !maze[x - 1, y]) count++;
            if (x < width - 1 && !maze[x + 1, y]) count++;
            if (y > 0 && !maze[x, y - 1]) count++;
            if (y < height - 1 && !maze[x, y + 1]) count++;
            return count == 1;
        }

        // Add neighboring walls of the cell to the list
        private void AddWalls(int x, int y, List<Tuple<int, int>> walls)
        {
            if (x > 0) walls.Add(new Tuple<int, int>(x - 1, y));
            if (x < width - 1) walls.Add(new Tuple<int, int>(x + 1, y));
            if (y > 0) walls.Add(new Tuple<int, int>(x, y - 1));
            if (y < height - 1) walls.Add(new Tuple<int, int>(x, y + 1));
        }
    }
}
