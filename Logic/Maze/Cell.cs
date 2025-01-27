namespace AntMaze;
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
