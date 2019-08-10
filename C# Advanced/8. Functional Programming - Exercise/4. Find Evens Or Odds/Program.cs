using System;
using System.Linq;
using System.Collections.Generic;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main()
        {
            Action<List<int>> printNumbers = result => Console.WriteLine(String.Join(" ", result));
            Predicate<int> isEven = num => num % 2 == 0;
            Predicate<int> isOdd = num => num % 2 != 0;

            //input parameters
            int[] inputBoundRange = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lowerRange = inputBoundRange[0];
            int upperRange = inputBoundRange[1];
            string command = Console.ReadLine();

            //Fill List collection from lowerRange to upperRange.
            List<int> numbers = Enumerable.Range(lowerRange, upperRange - lowerRange + 1)
                .ToList();

            //filterd collection by condition.
            numbers = numbers
                .Where(x => command == "even" ? isEven(x) : isOdd(x))
                .ToList();

            printNumbers(numbers);
        }
    }
}
