
using System.ComponentModel;

namespace CodeCraftMarsRover;

public class Rover
{
    public int Y { get; set; }

    public Direction Direction { get; set; }

    public void MoveForward()
    {
        if (Direction == Direction.South)
        {
            Y--;
        }
        else
        {
            Y++;
        }
    }
}