using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main()
        {
            Action<int[]> printArray = numbers => Console.WriteLine(string.Join(" ", numbers));
            Func<int[], int[]> reverseArray = numbers =>
            {
                int[] newReverseArray = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    newReverseArray[i] = numbers[numbers.Length - 1 - i];
                }

                return newReverseArray;
            };

            Func<string, int> parseElementToNumber = number =>
            {
                return int.Parse(number);
            };

            int[] inputElements = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(parseElementToNumber)
               .ToArray();
            int divisible = int.Parse(Console.ReadLine());

            Predicate<int> filtredAllElementsByDivisible = x => x % divisible != 0;

            inputElements = reverseArray(inputElements).Where(x => filtredAllElementsByDivisible(x)).ToArray();
            printArray(inputElements);
        }
    }
}
