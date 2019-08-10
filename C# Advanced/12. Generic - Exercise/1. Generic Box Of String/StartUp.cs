using System;

namespace GenericBoxOfString
{
    class StartUp
    {
        static void Main()
        {
            Box<string> box = new Box<string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                box.Add(Console.ReadLine());
            }

            Console.WriteLine(box.ToString());
        }
    }
}
