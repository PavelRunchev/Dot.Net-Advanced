using System;
using System.Linq;

namespace AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main()
        {
            Action<int[]> printCollection = numbers => Console.WriteLine(String.Join(" ", numbers));
            Func<int[], int[]> encrementAllElements = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i]++;
                }

                return numbers;
            };

            Func<int[], int[]> multiplyAllElements = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] *= 2;
                }

                return numbers;
            };

            Func<int[], int[]> subtractAllElements = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i]--;
                }

                return numbers;
            };

            int[] inputElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string commands;
            while((commands = Console.ReadLine()) != "end")
            {
                switch (commands)
                {
                    case "add": inputElements = encrementAllElements(inputElements); break;
                    case "multiply": inputElements = multiplyAllElements(inputElements); break;
                    case "subtract": inputElements = subtractAllElements(inputElements); break;
                    case "print": printCollection(inputElements); break;
                }
            }
        }
    }
}
