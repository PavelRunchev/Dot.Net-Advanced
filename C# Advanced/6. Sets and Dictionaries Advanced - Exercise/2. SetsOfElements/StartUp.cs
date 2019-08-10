using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class StartUp
    {
        static void Main()
        {
            HashSet<int> dataNNumbers = new HashSet<int>();
            HashSet<int> dataMNumbers = new HashSet<int>();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = numbers[0];
            int m = numbers[1];

            for (int i = 0; i < n; i++)
            {
                dataNNumbers.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                dataMNumbers.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var num in dataNNumbers)
            {
                if (dataMNumbers.Contains(num))
                {
                    Console.Write($"{num} ");
                }
            }

            Console.WriteLine();
        }
    }
}
