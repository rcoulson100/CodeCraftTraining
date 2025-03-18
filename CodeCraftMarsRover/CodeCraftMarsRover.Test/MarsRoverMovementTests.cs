namespace CodeCraftMarsRover.Test;

[TestFixture]
public class MarsRoverMovementTests
{
    [TestCase(1, 2)]
    [TestCase(2, 3)]
    public void MoveForwardWhenFacingNorth(int startPosition, int endPosition)
    {
        Rover rover = new()
        {
            Y = startPosition,
            Direction = Direction.North
        };
        rover.MoveForward();
        Assert.That(rover.Y, Is.EqualTo(endPosition));
    }

    [TestCase(2, 1)]
    [TestCase(3, 2)]
    public void MoveForwardWhenFacingSouth(int startPosition, int endPosition)
    {
        Rover rover = new()
        {
            Y = startPosition,
            Direction = Direction.South
        };
        rover.MoveForward();
        Assert.That(rover.Y, Is.EqualTo(endPosition));
    }

    [TestCase(1,2)]
    [TestCase(2,3)]
    public void MoveForwardWhenFacingEast(int startPosition, int endPosition)
    {
        Rover rover = new()
        {
            X = startPosition,
            Direction = Direction.East
        };
        rover.MoveForward();
        Assert.That(rover.X, Is.EqualTo(endPosition));
    }

    [TestCase(3,2)]
    [TestCase(2, 1)]
    public void MoveForwardWhenFacingWest(int startPosition, int endPosition)
    {
        Rover rover = new()
        {
            X = startPosition,
            Direction = Direction.West
        };
        rover.MoveForward();
        Assert.That(rover.X, Is.EqualTo(endPosition));
    }

    [Test]
    public void MoveBackwardWhenFacingNorth()
    {
        Rover rover = new()
        {
            Y = 2,
            Direction = Direction.North
        };
        rover.MoveBackward();

        Assert.That(rover.Y, Is.EqualTo(1));
    }

    [Test]
    public void MoveBackwardWhenFacingEast()
    {
        Rover rover = new()
        {
            X = 2,
            Direction = Direction.East
        };
        rover.MoveBackward();
        Assert.That(rover.X, Is.EqualTo(1));
    }

    [Test]
    public void MoveBackwardWhenFacingSouth()
    {
        Rover rover = new()
        {
            Y = 1,
            Direction = Direction.South
        };
        rover.MoveBackward();
        Assert.That(rover.Y, Is.EqualTo(2));
    }
}