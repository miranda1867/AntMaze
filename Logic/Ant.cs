namespace AntMaze;
public class Ant
{
    public string Name { get; set; }
    public string Skill { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Cooldown { get; set; }
    public bool SkillAvailable => Cooldown == 0;

    public Ant(string name, string skill)
    {
        Name = name;
        Skill = skill;
        Cooldown = 0;
    }

    public void UseSkill(Maze maze)
        {
            if (SkillAvailable)
            {
                switch (Skill)
                {
                    case "Revelar parte del laberinto":
                        // Aquí tengo la Lógica para revelar parte del laberinto
                        break;
                    case "Movimiento extra":
                        // Lógica para movimiento extra
                        break;
                    case "Crear barrera":
                        maze.PlaceBarrier(X, Y);
                        Console.WriteLine($"{Name} ha creado una barrera en ({X}, {Y})");
                        break;
                    case "Invisibilidad temporal":
                        // Lógica para la invisibilidad temporal
                        break;
                    case "Interrumpir turno del oponente":
                        // Lógica para interrumpir turno del oponente
                        break;
                }

                Cooldown = 1; // aquí el tiempo de enfriamiento
            }
            else
            {
                Console.WriteLine($"La habilidad de {Name} está en enfriamiento por {Cooldown} turnos.");
            }
        }

        public void ReduceCooldown()
        {
            if (Cooldown > 0) Cooldown--;
        }
}