namespace AntMaze;
//La clase Cell representa una sola celda en el laberinto. Rastrea si la celda es un obstáculo y si está oculta a la vista.
public class Cell
{
    public bool IsObstacle { get; set; }
    public bool IsHidden { get; set; }
    public Cell(bool isObstacle, bool isHidden)
        {
            IsObstacle = isObstacle;
            IsHidden = isHidden;
            //cambio
        }
}
