using Asteroids.GameProcess;
using System.Drawing;

namespace Asteroids.GameObjects
{
    public class Asteroid : BaseObject
    {
        
        public Asteroid(Point position, Point direction, Size size) : base(position, direction, size)
        {
        }

        private static Image _asteroid = Image.FromFile("Images\\asteroid.png");

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(_asteroid, _position);
        }

        public override void Update()
        {
            _position.X += _direction.X;
            if (_position.X < -5)
            {
                _position.X = Game.Width;
                _position.Y = Game.r.Next(0, Game.Height - 20);
                _direction.X = Game.r.Next(-6, -3);
            }
        }

        public override void RestartPos()
        {
            _position.X = Game.Width;
            _position.Y = Game.r.Next(0, Game.Height - 20);
        }
    }
}
