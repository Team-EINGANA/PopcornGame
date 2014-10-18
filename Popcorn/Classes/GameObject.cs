namespace Popcorn.Structures
{
    public abstract class GameObject : IDrawable, ICollidable
    {
        protected Position position;
        protected Size size;
        protected string imagePath;

        public void AddObject(IGameObject drawableObject)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveObject(IGameObject drawableObject)
        {
            throw new System.NotImplementedException();
        }

        public void RedrowObject(IGameObject drawableObject)
        {
            throw new System.NotImplementedException();
        }
    }
}
