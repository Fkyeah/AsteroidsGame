using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Menu
{
    public class Name : BaseText
    {
        public Name(string value, Point position, Point direction, Size size) : base(value, position, direction, size)
        {
        }

        public override void UpdatePosition()
        {
            if (Position.X < MainMenu.Width / 2 - 50)
                Position.X += Direction.X;
        }
    }
}
