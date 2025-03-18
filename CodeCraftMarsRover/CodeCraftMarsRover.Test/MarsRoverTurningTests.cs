namespace CodeCraftMarsRover.Test;

[TestFixture]
public class MarsRoverTurningTests
{
    [Test]
    public void TurnRightWhenFacingNorth()
    {
        Rover rover = new()
        {
            Direction = Direction.North
        };
        rover.TurnRight();
        Assert.That(rover.Direction, Is.EqualTo(Direction.East));
    }

    [Test]
    public void TurnRightWhenFacingEast()
    {
        Rover rover = new()
        {
            Direction = Direction.East
        };
        rover.TurnRight();
        Assert.That(rover.Direction, Is.EqualTo(Direction.South));
    }

    [Test]
    public void TurnRightWhenFacingSouth()
    {
        Rover rover = new()
        {
            Direction = Direction.South
        };
        rover.TurnRight();
        Assert.That(rover.Direction, Is.EqualTo(Direction.West));
    }

    [Test]
    public void TurnRightWhenFacingWest()
    {
        Rover rover = new()
        {
            Direction = Direction.West
        };
        rover.TurnRight();
        Assert.That(rover.Direction, Is.EqualTo(Direction.North));
    }

    [Test]
    public void TurnLeftWhenFacingNorth()
    {
        Rover rover = new()
        {
            Direction = Direction.North
        };
        rover.TurnLeft();
        Assert.That(rover.Direction, Is.EqualTo(Direction.West));
    }

    [Test]
    public void TurnLeftWhenFacingWest()
    {
        Rover rover = new()
        {
            Direction = Direction.West
        };
        rover.TurnLeft();
        Assert.That(rover.Direction, Is.EqualTo(Direction.South));
    }

    [Test]
    public void TurnLeftWhenFacingSouth()
    {
        Rover rover = new()
        {
            Direction = Direction.South
        };
        rover.TurnLeft();
        Assert.That(rover.Direction, Is.EqualTo(Direction.East));
    }

    [Test]
    public void TurnLeftWhenFacingEast()
    {
        Rover rover = new()
        {
            Direction = Direction.East
        };
        rover.TurnLeft();
        Assert.That(rover.Direction, Is.EqualTo(Direction.North));
    }

}
