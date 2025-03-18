namespace CodeCraftMarsRover.Test;

[TestFixture]
public class MarsRoverTurningTests
{
    [TestCase(Direction.North, Direction.East)]
    [TestCase(Direction.East, Direction.South)]
    [TestCase(Direction.South, Direction.West)]
    [TestCase(Direction.West, Direction.North)]
    public void TurnRight(Direction originalDirection, Direction expectedDirection)
    {
        Rover rover = new()
        {
            Direction = originalDirection
        };
        rover.TurnRight();
        Assert.That(rover.Direction, Is.EqualTo(expectedDirection));
    }

    [TestCase(Direction.North, Direction.West)]
    [TestCase(Direction.West, Direction.South)]
    [TestCase(Direction.South, Direction.East)]
    [TestCase(Direction.East, Direction.North)]
    public void TurnLeft(Direction originalDirection, Direction expectedDirection)
    {
        Rover rover = new()
        {
            Direction = originalDirection
        };
        rover.TurnLeft();
        Assert.That(rover.Direction, Is.EqualTo(expectedDirection));
    }
}
