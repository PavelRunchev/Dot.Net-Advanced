using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class StartUp
    {
        static void Main()
        {
            HashSet<string> elements = new HashSet<string>();
            int countInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < countInput; i++)
            {
                string[] inputElements = Console.ReadLine().Split();
                foreach (string el in inputElements)
                {
                    elements.Add(el);
                }
            }

            HashSet<string> sortedElements = elements.OrderBy(a => a).ToHashSet();
            Console.WriteLine(String.Join(" ", sortedElements));
        }
    }
}
