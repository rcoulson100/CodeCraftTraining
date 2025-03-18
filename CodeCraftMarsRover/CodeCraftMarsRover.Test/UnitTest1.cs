using System.ComponentModel;

namespace CodeCraftMarsRover.Test
{
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
        public void MoveForwardWhenFacingSouth()
        {
            Rover rover = new()
            {
                Y = 2,
                Direction = Direction.South
            };
            rover.MoveForward();
            Assert.That(rover.Y, Is.EqualTo(1));

        }
    }
}