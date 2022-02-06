using System.Drawing;

namespace Asteroids.Menu
{
    public class BaseText
    {
        public BaseText(string value, Point position, Point direction, Size size)
        {
            Position = position;
            Direction = direction;
            Size = size;
            Value = value;
        }

        public Point Position;
        protected Point Direction;
        protected Size Size;
        public string Value;

        public virtual void UpdatePosition()
        {
            if (Position.Y < MainMenu.Height / 2 - 50)
                Position.Y += Direction.Y;
        }

        public void WriteText()
        {
            MainMenu.Buffer.Graphics.DrawString(Value, SystemFonts.MenuFont, Brushes.White, Position, StringFormat.GenericTypographic);
        }
    }
}
