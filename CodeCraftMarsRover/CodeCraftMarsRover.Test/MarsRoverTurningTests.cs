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
}
