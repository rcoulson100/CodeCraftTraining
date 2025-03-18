namespace CodeCraftMarsRover.Test;

[TestFixture]
public class Tests
{
    [Test]
    public void MoveForwardWhenFacingNorth()
    {
        Rover rover = new()
        {
            Y = 1,
            Direction = Direction.North
        };
        rover.MoveForward();
        Assert.That(rover.Y, Is.EqualTo(2));
    }

    [Test]
    public void MoveForwardTwiceWhenFacingNorth()
    {
        Rover rover = new()
        {
            Y = 1,
            Direction = Direction.North
        };
        rover.MoveForward();
        rover.MoveForward();
        Assert.That(rover.Y, Is.EqualTo(3));
    }

    [Test]
    public void MoveForwardWhenFacingSouth()
    {
        Rover rover = new()
        {
            Y = 3,
            Direction = Direction.South
        };
        rover.MoveForward();
        Assert.That(rover.Y, Is.EqualTo(2));
    }

    [Test]
    public void MoveForwardTwiceWhenFacingSouth()
    {
        Rover rover = new()
        {
            Y = 3,
            Direction = Direction.South
        };
        rover.MoveForward();
        rover.MoveForward();
        Assert.That(rover.Y, Is.EqualTo(1));
    }

    [Test]
    public void MoveForwardWhenFacingEast()
    {
        Rover rover = new()
        {
            X = 3,
            Direction = Direction.East
        };
        rover.MoveForward();
        Assert.That(rover.X, Is.EqualTo(4));
    }

    [Test]
    public void MoveForwardTwiceWhenFacingEast()
    {
        Rover rover = new()
        {
            X = 3,
            Direction = Direction.East
        };
        rover.MoveForward();
        rover.MoveForward();
        Assert.That(rover.X, Is.EqualTo(5));
    }

    [Test]
    public void MoveForwardWhenFacingWest()
    {
        Rover rover = new()
        {
            X = 3,
            Direction = Direction.West
        };
        rover.MoveForward();
        Assert.That(rover.X, Is.EqualTo(2));
    }

    [Test]
    public void MoveForwardTwiceWhenFacingWest()
    {
        Rover rover = new()
        {
            X = 3,
            Direction = Direction.West
        };
        rover.MoveForward();
        rover.MoveForward();
        Assert.That(rover.X, Is.EqualTo(1));
    }
}