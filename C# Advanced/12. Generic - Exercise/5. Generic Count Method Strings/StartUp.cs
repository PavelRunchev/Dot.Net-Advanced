using System;

namespace GenericCountMethodStrings
{
    class StartUp
    {
        static void Main()
        {
            Box<string> box = new Box<string>();
            int countElements = int.Parse(Console.ReadLine());
            for (int i = 0; i < countElements; i++)
            {
                box.Add(Console.ReadLine());
            }

            string comparisonElement = Console.ReadLine();
            box.CountMethod(comparisonElement);

            Console.WriteLine(box.Data.Count);
        }
    }
}
