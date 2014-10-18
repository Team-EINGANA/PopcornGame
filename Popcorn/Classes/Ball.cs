using Popcorn.Interfaces;

namespace Popcorn.Classes
{
    public class Ball : GameObject, IMovable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int SetX { get; set; }
        public int SetY { get; set; }
        public int MovementSpeed { get; set; }
        public Direction Direction { get; set; }
        public void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}
