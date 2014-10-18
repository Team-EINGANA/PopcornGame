using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Popcorn.Interfaces
{
    public interface IGameObject
    {
        int X { get; set; }
        int Y { get; set; }
        int SizeX { get; set; }
        int SizeY { get; set; }
    }
}
