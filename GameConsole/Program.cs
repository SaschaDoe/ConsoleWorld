using System;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.CursorVisible = false;
            
            Console.WriteLine("Console World");
            Console.WriteLine();
            Console.WriteLine("1 New Game");
            Console.WriteLine("or Exit");
            var input = Console.ReadLine();
            if (input.Equals("1"))
            {
                
            }

        }
    }
}
