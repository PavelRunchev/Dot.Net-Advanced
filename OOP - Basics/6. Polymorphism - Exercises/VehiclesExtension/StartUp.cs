using System;
using VehiclesExtension.Core;

namespace VehiclesExtension
{
    public class StartUp
    {
        static void Main()
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
