using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Popcorn.Interfaces;
using Popcorn.Structures;

namespace Popcorn.Classes.Bonuses
{
    public abstract class Bonus : GameObject, IMovable, IBonus, ITimeoutable
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
