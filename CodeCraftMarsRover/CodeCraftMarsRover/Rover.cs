
using System.ComponentModel;

namespace CodeCraftMarsRover;

public class Rover
{
    public int X { get; set; }

    public int Y { get; set; }

    public Direction Direction { get; set; }


    public void MoveForward()
    {
        if (Direction == Direction.South)
        {
            Y--;
        }
        else if (Direction == Direction.East)
        {
            X++;
        }
        else if (Direction == Direction.West)
        {
            X--;
        }
        else
        {
            Y++;
        }
    }

    public void TurnRight()
    {
        if (Direction == Direction.North)
        {
            Direction = Direction.East;
        }
        else
        {
            Direction = Direction.South;
        }
    }
}