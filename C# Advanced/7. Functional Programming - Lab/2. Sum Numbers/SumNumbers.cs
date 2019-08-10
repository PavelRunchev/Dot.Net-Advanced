using System;
using System.Linq;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            int[] inputArrayFromNumbers = Console.ReadLine()
                .Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int countElementsInArray = inputArrayFromNumbers.Count();
            int sumFromAllElementsInArray = inputArrayFromNumbers.Sum();
            Console.WriteLine(countElementsInArray);
            Console.WriteLine(sumFromAllElementsInArray);
        }
    }
}
