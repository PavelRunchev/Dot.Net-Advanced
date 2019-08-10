using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class StartUp
    {
        static void Main()
        {
            int countOfElements = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < countOfElements; i++)
            {
                int[] inputOperations = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int operation = inputOperations[0];
                if(operation == 1 && inputOperations.Length == 2)
                {
                    numbers.Push(inputOperations[1]);
                }
                else if (operation == 2 && numbers.Count > 0)
                {                   
                    numbers.Pop();
                }
                else if(operation == 3 && numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Max());
                }
                else if(operation == 4 && numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Min());
                }
            }

            if(numbers.Count > 0)
                Console.WriteLine(String.Join(", ", numbers.ToArray()));
        }
    }
}
