using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Popcorn.Interfaces;

namespace Popcorn.Classes
{
    public class Brick : GameObject
    {
        public const ImageType image = ImageType.SimpleBrick;

        public Brick(int x, int y, int sizeX, int sizeY)
        {
            this.X = x;
            this.Y = y;
            this.SizeX = sizeX;
            this.SizeY = sizeY;
            this.Image = image;
        }

    }
}
