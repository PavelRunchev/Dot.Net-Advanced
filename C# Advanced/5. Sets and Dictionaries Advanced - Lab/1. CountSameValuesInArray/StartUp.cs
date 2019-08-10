using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class StartUp
    {
        static void Main()
        {
            Dictionary<double, int> dataNumbers = new Dictionary<double, int>();
            double[] inputNumbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            foreach (double num in inputNumbers)
            {
                if (!dataNumbers.ContainsKey(num))
                    dataNumbers.Add(num, 0);

                dataNumbers[num]++;
            }

            foreach (var kvp in dataNumbers)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }

        }
    }
}
