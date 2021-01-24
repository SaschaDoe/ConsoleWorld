namespace GameLogic.World
{
    public class Room
    {
        public Room(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Height { get; }
        public int Width { get; }
    }
}