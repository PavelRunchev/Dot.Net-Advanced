using SimpleSnake.Core;
using System;
using SimpleSnake.GameObjects;
using SimpleSnake.GameObjects.Foods;

namespace SimpleSnake
{
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();
            Snake snake = new Snake();
           
            Engine engine = new Engine(snake);
            engine.Run();
        }
    }
}
