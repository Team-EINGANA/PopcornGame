using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Popcorn.Structures;

namespace Popcorn.Interfaces
{
    // Painting Interface
    public interface IDrawingInterface
    {
        void AddObject(IDrawable drawableObject);
        void RemoveObject(IDrawable drawableObject);
        void RedrawObject(IDrawable drawableObject);
    }
}
