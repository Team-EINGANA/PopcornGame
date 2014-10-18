using Popcorn.Interfaces;
using Popcorn.Structures;

namespace Popcorn.Classes
{
    public abstract class GameObject : ICollidable, IGameObject, IDrawable
    {
        protected Position position;
        protected Size size;
        
        public int X { get; set; }
        public int Y { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public ImageType Image { get; set; }
    }
}
