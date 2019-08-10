using System;
using System.Linq;

namespace GenericSwapMethodStrings
{
    class StartUp
    {
        static void Main()
        {
            Box<string> box = new Box<string>();
            int countItems = int.Parse(Console.ReadLine());
            for (int i = 0; i < countItems; i++)
            {
                box.Add(Console.ReadLine());
            }

            int[] inputIndexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = inputIndexes[0];
            int secondIndex = inputIndexes[1];
            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box.ToString());
        }
    }
}
