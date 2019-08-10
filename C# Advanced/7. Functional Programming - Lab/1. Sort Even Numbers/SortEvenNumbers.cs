using System;
using System.Linq;

namespace SortEvenNumbers
{
    class SortEvenNumbers
    {
        static void Main()
        {
            int[] arrayFromNumbers = Console.ReadLine()
                .Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(e => e % 2 == 0)
                .OrderBy(e => e)
                .ToArray();
            Console.WriteLine(String.Join(", ", arrayFromNumbers));
        }
    }
}
