using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
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
            Stack<int> numbers = new Stack<int>();
            //Added elements from input!
            for (int i = 0; i < countOfElements; i++)
            {
                numbers.Push(inputNumbers[i]);
            }

            //Removed elements from Stack!
            for (int i = 0; i < removeElements; i++)
            {
                if(numbers.Count == 0) break;

                numbers.Pop();
            }

            if(numbers.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }

            if (numbers.Contains(checkElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }        
        }
    }
}
