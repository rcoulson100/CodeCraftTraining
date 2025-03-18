using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCraftMarsRover.Test;

[TestFixture]
public class MarsRoverControllerTests
{
    [Test]
    public void DoNothingWhenEmptyCommand()
    {
        Rover rover = new()
        {
            X = 1,
            Y = 1,
            Direction = Direction.North
        };

        RoverController controller = new()
        {
            Rover = rover
        };

        controller.ExecuteCommand("");

        Assert.That(rover.X, Is.EqualTo(1));
        Assert.That(rover.Y, Is.EqualTo(1));
        Assert.That(rover.Direction, Is.EqualTo(Direction.North));
    }
}
