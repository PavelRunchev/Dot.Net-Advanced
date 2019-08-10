using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTImes
{
    class StartUp
    {
        static void Main()
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            int countNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < countNumbers; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(inputNumber))
                    numbers.Add(inputNumber, 0);

                numbers[inputNumber]++;
            }


            foreach (var kvp in numbers)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
}
