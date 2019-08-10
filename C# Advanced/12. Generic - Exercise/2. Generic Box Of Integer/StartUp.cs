using System;

namespace GenericBoxOfInteger
{
    public class StartUp
    {
        static void Main()
        {
            Box<int> box = new Box<int>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                box.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(box.ToString());
        }
    }
}
