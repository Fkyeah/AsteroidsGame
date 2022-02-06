using System.Drawing;

namespace Asteroids.Menu
{
    public class SurName : BaseText
    {
        public SurName(string value, Point position, Point direction, Size size) : base(value, position, direction, size)
        {
        }

        public override void UpdatePosition()
        {
            if (Position.X > MainMenu.Width / 2 + 20)
                Position.X += Direction.X;
        }
    }
}
