
using System.ComponentModel;
using System.ComponentModel.Design;

namespace CodeCraftMarsRover;

public class Rover
{
    public int X { get; set; }

    public int Y { get; set; }

    public Direction Direction { get; set; }

    public void MoveBackward()
    {
        if (Direction == Direction.North)
        {
            Y--;
        }
        else if (Direction == Direction.South)
        {
            Y++;
        }
        X = 1;
    }

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

    public void TurnLeft()
    {
        Direction = Direction switch
        {
            Direction.North => Direction.West,
            Direction.West => Direction.South,
            Direction.South => Direction.East,
            _ => Direction.North,
        };
    }

    public void TurnRight()
    {
        Direction = Direction switch
        {
            Direction.North => Direction.East,
            Direction.East => Direction.South,
            Direction.South => Direction.West,
            _ => Direction.North,
        };
    }
}