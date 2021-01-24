using System;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var loading = 0;
            Console.CursorVisible = false;
            while (true)
            {
                Task.Delay(100).Wait();
                Console.SetCursorPosition(0,0);
                Console.Write("Loading... ");
                switch (loading)
                {
                    case 0:
                        Console.Write("-");
                        loading++;
                        break;
                    case 1:
                        Console.Write("\\");
                        loading++;
                        break;
                    case 2:
                        Console.Write("|");
                        loading++;
                        break;
                    default:
                        Console.Write("/");
                        loading = 0;
                        break;
                        
                }
               
                
            }
            
        }
    }
}
