using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Popcorn.Interfaces;

namespace Popcorn
{
    public class Pan : GameObject, IMovable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int SetX { get; set; }
        public int SetY { get; set; }
        public int MovementSpeed { get; set; }
        public Direction Direction { get; set; }
        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
