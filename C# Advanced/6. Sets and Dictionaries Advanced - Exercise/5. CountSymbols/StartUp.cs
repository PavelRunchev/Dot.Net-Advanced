using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class StartUp
    {
        static void Main()
        {
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            string inputText = Console.ReadLine();

            foreach (char item in inputText)
            {
                if (!symbols.ContainsKey(item))
                    symbols.Add(item, 0);

                symbols[item]++;
            }

            foreach (var kvp in symbols)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
