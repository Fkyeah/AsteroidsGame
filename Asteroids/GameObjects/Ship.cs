using System.Drawing;

namespace Asteroids.GameObjects
{
    public class Ship : BaseObject
    {
        public Ship(Point position, Point direction, Size size) : base(position, direction, size)
        {
        }

        private static Image _ship = Image.FromFile("Images\\ship.png");

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(_ship, _position);
        }

        public override void Update()
        {
            _position.X += _direction.X;
            _position.Y += _direction.Y;
        }

        public void Up()
        {
            _direction.Y = -Math.Abs(_direction.Y);
        }

        public void Down()
        {
            _direction.Y = Math.Abs(_direction.Y);
        }
    }
}
