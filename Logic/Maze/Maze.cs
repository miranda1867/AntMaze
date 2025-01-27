using System;

namespace AntMaze
{
    public class Maze
    {
        public Cell[,] Cells { get; private set; }

        public Maze(int width, int height)
        {
            Cells = new Cell[width, height];
            InitializeMaze(width, height);
        }

        public void InitializeMaze(int width, int height)
        {
            MazeGenerator generator = new MazeGenerator(width, height);
            bool[,] maze = generator.GenerateMaze();

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Cells[x, y] = new Cell(maze[x, y], true);
                }
            }
        }

        public void ShowCell(int x, int y)
        {
            Cells[x, y].IsHidden = false;
        }

        public void MoveAnt(Ant ant, int newX, int newY)
        {
            if (newX >= 0 && newX < Cells.GetLength(0) && newY >= 0 && newY < Cells.GetLength(1))
            {
                if (!Cells[newX, newY].IsObstacle)
                {
                    ant.X = newX;
                    ant.Y = newY;
                }
                else
                {
                    ant.Cooldown = 1;
                    Console.WriteLine($"{ant.Name} chocó con un obstáculo.");
                }
            }
        }

        public void PlaceBarrier(int x, int y)
        {
            if (x >= 0 && x < Cells.GetLength(0) && y >= 0 && y < Cells.GetLength(1))
            {
                Cells[x, y].IsObstacle = true;
            }
        }
    }
}
