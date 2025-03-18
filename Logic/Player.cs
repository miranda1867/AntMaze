using System.Collections.Generic;

//La clase Player representa a un jugador en el juego, gestionando su hormiga. Incluye métodos para agregar una hormiga y usar su habilidad.

namespace AntMaze
{
    public class Player
    {
        public string Name { get; set; }
        public List<Ant> Ants { get; set; }

        public Player(string name)
        {
            Name = name;
            Ants = new List<Ant>();
        }

        public void AddAnt(Ant ant)
        {
            Ants.Add(ant);
        }

        public void UseAntSkill(string antName, Maze maze)
        {
            var ant = Ants.Find(a => a.Name == antName);
            if (ant != null && ant.SkillAvailable)
            {
                ant.UseSkill(maze); // Pasar el laberinto para aplicar la habilidad
            }
        }

        public void ReduceCooldowns()
        {
            foreach (var ant in Ants)
            {
                ant.ReduceCooldown();
            }
        }
    }
}
