
using System.ComponentModel;

namespace CodeCraftMarsRover.Test;

internal class Rover
{
    public int Y { get; set; }

    public Direction Direction { get; set; }


    internal void MoveForward()
    {
        if (Direction == Direction.South)
        {
            Y = 1;
        }
        else
        {
            Y++;
        }
    }
}