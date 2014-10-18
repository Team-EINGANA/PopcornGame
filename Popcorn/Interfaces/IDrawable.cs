using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Popcorn.Classes;

namespace Popcorn.Interfaces
{
    public interface IDrawable : IGameObject
    {
        ImageType Image { get; set; }
    }
}
