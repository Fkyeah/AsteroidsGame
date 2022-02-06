using Asteroids.GameProcess;
using System.Drawing;

namespace Asteroids.GameObjects
{
    public class FirstAidKit : BaseObject
    {
        public FirstAidKit(Point position, Point direction, Size size) : base(position, direction, size)
        {
        }

        private static Image _firstAidKit = Image.FromFile("Images\\first_aid_kit.jpg");

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(_firstAidKit, _position);
        }

        public override void Update()
        {
            _position.X += _direction.X;
            if (_position.X < -5)
            {
                _position.X = Game.Width;
                _direction.X = 0;
            }
        }

        public override void RestartPos()
        {
            _position.X = Game.Width;
            _position.Y = Game.r.Next(0, Game.Height - 20);
            _direction.X = 0;
        }
    }
}
