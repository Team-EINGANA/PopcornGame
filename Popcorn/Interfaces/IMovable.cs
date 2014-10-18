namespace Popcorn.Structures
{
    public interface IMovable: IGameObject
    {
        int MovementSpeed { get; set; }
        Direction Direction { get; set; }
        void Move();
    }
}
