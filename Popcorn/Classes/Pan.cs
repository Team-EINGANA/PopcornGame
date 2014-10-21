using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Popcorn.Interfaces;
using Popcorn.Structures;

namespace Popcorn.Classes
{
    public class Pan : GameObject, IMovable
    {
        public int MovementSpeed { get; set; }
        public Direction Direction { get; set; }
        public const ImageType image = ImageType.Pan;

        public Pan(int x, int y, int sizeX, int sizeY)
        {
            this.X = x;
            this.Y = y;
            this.SizeX = sizeX;
            this.SizeY = sizeY;
            this.Image = image;
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
