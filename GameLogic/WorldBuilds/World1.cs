using GameLogic.Character;
using GameLogic.World;

namespace GameLogic.WorldBuilds
{
    public class World1 : IWorld
    {
        public Room StartRoom { get; }
        public Player Player { get; }

        public World1()
        {
            StartRoom = new Room(10,10);
            Player = new Player(5,5);
        }
    }
}