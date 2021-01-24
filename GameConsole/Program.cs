using System;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var loadingCounter = 0;
            Console.CursorVisible = false;
            while (true)
            {
                Task.Delay(100).Wait();
                Console.SetCursorPosition(0,0);
                Console.Write("Loading... ");
                switch (loadingCounter)
                {
                    case 0:
                        Console.Write("-");
                        loadingCounter++;
                        break;
                    case 1:
                        Console.Write("\\");
                        loadingCounter++;
                        break;
                    case 2:
                        Console.Write("|");
                        loadingCounter++;
                        break;
                    default:
                        Console.Write("/");
                        loadingCounter = 0;
                        break;
                        
                }
               
                
            }
            
        }
    }
}
