namespace GameLogic.Character
{
    public class Player
    {
        public Player(int y, int x)
        {
            Y = y;
            X = x;
        }

        public int X { get; }
        public int Y { get; }
    }
}