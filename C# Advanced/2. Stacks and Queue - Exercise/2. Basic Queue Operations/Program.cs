using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main()
        {
            int[] inputOperations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countOfElements = inputOperations[0];
            int removeElements = inputOperations[1];
            int checkElement = inputOperations[2];

            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();
            //Added elements from input!
            for (int i = 0; i < countOfElements; i++)
            {
                numbers.Enqueue(inputNumbers[i]);
            }

            //Removed elements from Stack!
            for (int i = 0; i < removeElements; i++)
            {
                if (numbers.Count == 0) break;

                numbers.Dequeue();
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }

            Console.WriteLine(numbers.Contains(checkElement) ? "true" : $"{numbers.Min()}");          
        }
    }
}
