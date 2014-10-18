using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Popcorn.Structures
{
    public struct Direction
    {
        public Direction(int x, int y)
            : this()
        {
            this.DirX = x;
            this.DirY = y;
        }

        public int DirX { get; set; }

        public int DirY { get; set; }
    }
}
