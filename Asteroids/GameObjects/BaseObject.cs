using Asteroids.GameObjects.Interfaces;
using System.Drawing;

namespace Asteroids.GameObjects
{
    public abstract class BaseObject : ICollision
    {
        public BaseObject(Point pos, Point dir, Size size)
        {
            _position = pos;
            _direction = dir;
            _size = size;
        }

        public Point Pos { get { return _position; } }
        public Point Dir { get { return _direction; } }
        public int DirX { set { _direction.X = value; } }
        public int DirY { set { _direction.Y = value; } }
        public Size Size { get { return _size; } }

        protected Point _position;
        protected Point _direction;
        protected Size _size;
        
        public Rectangle Rect => new Rectangle(_position, _size);

        public bool Collision(ICollision obj)
        {
            return obj.Rect.IntersectsWith(this.Rect);
        }

        public abstract void Draw();

        public abstract void Update();

        public virtual void RestartPos()
        {
            _position.X = 0;
            _position.Y = Game.r.Next(0, Game.Height - 20);
        }
    }
}
