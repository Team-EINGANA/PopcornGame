using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Popcorn
{
    public abstract class GameObject : IDrawable, ICollidable
    {
        protected Position position;
        protected Size size;
        protected string imagePath;
    }
}
