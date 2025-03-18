using System;
using System.Collections.Generic;

//La clase MazeGenerator es responsable de generar el laberinto usando el algoritmo de Prim. Inicializa el laberinto con paredes y crea caminos seleccionando paredes aleatoriamente y comprobando sus celdas vecinas.
//Incluye métodos para generar el laberinto, comprobar si una celda es parte del camino y agregar paredes vecinas a la lista de procesamiento.

namespace AntMaze
{
    public class MazeGenerator
    {
        private int width, height;
        private bool[,] maze;
        private Random rnd = new Random();

        //constructor de la clase MazeGnerator
        public MazeGenerator(int width, int height)
        {
            this.width = width; 
            this.height = height;
            maze = new bool[width, height];
        }

        //Método para generar el laberinto usando el algoritmo de Prim..
        public bool[,] GenerateMaze()
        {
            //imitialize maze with walls...
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    maze[x, y] = true; // True representa unan pared
                }
            }

            //start from a random point in the maze... requisite of project
            int startX = rnd.Next(width);
            int startY = rnd.Next(height);

            maze[startX, startY] = false; //false represents a path
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
                    maze[x, y] = false; //create a path in the maze...
                    AddWalls(x, y, walls); //Add neighboring walls a la lista...
                }
            }
            return maze;
        }

        //Check if the cell is part of the maze's path
        private bool IsPartOfPath(int x, int y)
        {
            int count = 0;
            if (x > 0 && !maze[x - 1, y]) count++; //verifica la celda izquierda 
            if (x < width - 1 && !maze[x + 1, y]) count++; //verifica la celda derecha
            if (y > 0 && !maze[x, y - 1]) count++; //arriba 
            if (y < height - 1 && !maze[x, y + 1]) count++; //abajo
            return count == 1;
        }

        //Add neighboring walls of the cell to the list
        private void AddWalls(int x, int y, List<Tuple<int, int>> walls)
        {
            if (x > 0) walls.Add(new Tuple<int, int>(x - 1, y));
            if (x < width - 1) walls.Add(new Tuple<int, int>(x + 1, y));
            if (y > 0) walls.Add(new Tuple<int, int>(x, y - 1));
            if (y < height - 1) walls.Add(new Tuple<int, int>(x, y + 1));
        }
    }
}
