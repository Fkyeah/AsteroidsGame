using System;

namespace Asteroids.Exceptions
{
    public class GameObjectException : Exception
    {
        public GameObjectException()
        {
            Console.WriteLine(base.Message);
        }
        public GameObjectException(string value)
        {
            Console.WriteLine(value);
        }
    }
}
