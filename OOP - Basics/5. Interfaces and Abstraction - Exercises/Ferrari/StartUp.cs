using System;

namespace Ferrari
{
    class StartUp
    {
        static void Main()
        {
            string driverName = Console.ReadLine();
            ICar ferarri = new Ferrari(driverName);

            Console.WriteLine(ferarri);
        }
    }
}
