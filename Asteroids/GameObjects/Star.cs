using System.Drawing;

namespace Asteroids.GameObjects
{
    public class Star : BaseObject
    {
        public Star(Point position, Point direction, Size size) : base(position, direction, size)
        {
        }

        private static Image _star = Image.FromFile("Images\\star.png");

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(_star, _position);
        }
        public override void Update()
        {
            _position.X += _direction.X;
            if (_position.X < -5) _position.X = Game.Width;
        }
    }
}
