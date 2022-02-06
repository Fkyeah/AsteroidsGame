using System;
using System.Drawing;

namespace Asteroids.GameObjects
{
    public class Bullet : BaseObject
    {
        public Bullet(Point position, Point direction, Size size) : base(position, direction, size)
        {

        }

        public static event Action<Bullet> OverScreen;
        static Image _bullet = Image.FromFile("Images\\bullet.png");

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(_bullet, _position);
        }

        public override void Update()
        {
            _position.X += _direction.X;
            if (_position.X > Game.Width)
            {
                OverScreen(this);
            }
        }
    }
}
