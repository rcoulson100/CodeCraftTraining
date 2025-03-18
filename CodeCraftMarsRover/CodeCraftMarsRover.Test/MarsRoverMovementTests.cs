namespace CodeCraftMarsRover.Test;

[TestFixture]
public class MarsRoverMovementTests
{
    [TestCase(1, 2, Direction.North)]
    [TestCase(2, 3, Direction.North)]
    [TestCase(2, 1, Direction.South)]
    [TestCase(3, 2, Direction.South)]
    public void MoveForwardWhenFacingNorth(int startPosition, int endPosition, Direction direction)
    {
        Rover rover = new()
        {
            Y = startPosition,
            Direction = direction
        };
        rover.MoveForward();
        Assert.That(rover.Y, Is.EqualTo(endPosition));
    }

    [TestCase(1, 2, Direction.East)]
    [TestCase(2, 3, Direction.East)]
    [TestCase(3, 2, Direction.West)]
    [TestCase(2, 1, Direction.West)]
    public void MoveForwardWhenFacingEast(int startPosition, int endPosition, Direction direction)
    {
        Rover rover = new()
        {
            X = startPosition,
            Direction = direction
        };
        rover.MoveForward();
        Assert.That(rover.X, Is.EqualTo(endPosition));
    }

    [TestCase(2, 1)]
    [TestCase(3, 2)]
    public void MoveBackwardWhenFacingNorth(int startPosition, int endPosition)
    {
        Rover rover = new()
        {
            Y = startPosition,
            Direction = Direction.North
        };
        rover.MoveBackward();

        Assert.That(rover.Y, Is.EqualTo(endPosition));
    }

    [TestCase(2, 1)]
    [TestCase(3, 2)]
    public void MoveBackwardWhenFacingEast(int startPosition, int endPosition)
    {
        Rover rover = new()
        {
            X = startPosition,
            Direction = Direction.East
        };
        rover.MoveBackward();
        Assert.That(rover.X, Is.EqualTo(endPosition));
    }

    [TestCase(1, 2)]
    [TestCase(2, 3)]
    public void MoveBackwardWhenFacingSouth(int startPosition, int endPosition)
    {
        Rover rover = new()
        {
            Y = startPosition,
            Direction = Direction.South
        };
        rover.MoveBackward();
        Assert.That(rover.Y, Is.EqualTo(endPosition));
    }

    [TestCase(1, 2)]
    [TestCase(2, 3)]
    public void MoveBackwardWhenFacingWest(int startPosition, int endPosition)
    {
        Rover rover = new()
        {
            X = startPosition,
            Direction = Direction.West
        };
        rover.MoveBackward();
        Assert.That(rover.X, Is.EqualTo(endPosition));
    }
}