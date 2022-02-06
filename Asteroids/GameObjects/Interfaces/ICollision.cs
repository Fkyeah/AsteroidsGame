using System.Drawing;

namespace Asteroids.GameObjects.Interfaces
{
    public interface ICollision
    {
        bool Collision(ICollision obj);
        Rectangle Rect { get; }
    }
}
