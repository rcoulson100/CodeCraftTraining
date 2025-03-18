namespace CodeCraftMarsRover.Test;

[TestFixture]
public class MarsRoverMovementTests
{
    [TestCase(1, 2, Direction.North)]
    [TestCase(2, 3, Direction.North)]
    [TestCase(2, 1, Direction.South)]
    [TestCase(3, 2, Direction.South)]
    public void MoveForwardAlongYAxis(int startPosition, int endPosition, Direction direction)
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
    public void MoveForwardAlongXAxis(int startPosition, int endPosition, Direction direction)
    {
        Rover rover = new()
        {
            X = startPosition,
            Direction = direction
        };
        rover.MoveForward();
        Assert.That(rover.X, Is.EqualTo(endPosition));
    }

    [TestCase(2, 1, Direction.North)]
    [TestCase(3, 2, Direction.North)]
    [TestCase(1, 2, Direction.South)]
    [TestCase(2, 3, Direction.South)]
    public void MoveBackwardAlongYAxis(int startPosition, int endPosition, Direction direction)
    {
        Rover rover = new()
        {
            Y = startPosition,
            Direction = direction
        };
        rover.MoveBackward();

        Assert.That(rover.Y, Is.EqualTo(endPosition));
    }

    [TestCase(2, 1, Direction.East)]
    [TestCase(3, 2, Direction.East)]
    [TestCase(1, 2, Direction.West)]
    [TestCase(2, 3, Direction.West)]
    public void MoveBackwardAlongXAxis(int startPosition, int endPosition, Direction direction)
    {
        Rover rover = new()
        {
            X = startPosition,
            Direction = direction
        };
        rover.MoveBackward();
        Assert.That(rover.X, Is.EqualTo(endPosition));
    }
}