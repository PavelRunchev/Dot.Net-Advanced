using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomComprator
{
    class CustomComparator
    {
        static void Main()
        {
           
            Predicate<int> func = x => x % 2 == 0;
            int[] inputNumbers = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .OrderBy(x => x)
               .ToArray();

            int[] sortedArray = inputNumbers.Where(x => func(x)).ToArray()
                .Concat(inputNumbers.Where(x => !func(x)).ToArray())
                .ToArray();
            Console.WriteLine(String.Join(" ", sortedArray));
        }
    }
}