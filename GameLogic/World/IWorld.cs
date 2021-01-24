using GameLogic.Character;

namespace GameLogic.World
{
    public interface IWorld
    {
        Room StartRoom { get; }
        Player Player { get; }
    }
}