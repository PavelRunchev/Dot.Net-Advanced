using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class StartUp
    {
        static void Main()
        {
            Stack<int> numbers = new Stack<int>();
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            numbers = AddElements(numbers, inputNumbers);

            string inputCommands;
            while ((inputCommands = Console.ReadLine().ToLower()) != "end")
            {
                string[] arguments = inputCommands.Split();
                string command = arguments[0];
                if(command == "add" && arguments.Length == 3)
                {
                    numbers.Push(int.Parse(arguments[1]));
                    numbers.Push(int.Parse(arguments[2]));
                }
                else if (command == "remove" && arguments.Length == 2)
                {
                    int removeElements = int.Parse(arguments[1]);
                    numbers = RemoveElements(numbers, removeElements);
                }
            }

            PrintTotalSumFromNumbers(numbers);
        }

        private static Stack<int> AddElements(Stack<int> numbers, int[] inputNumbers)
        {
            foreach (int num in inputNumbers)
            {
                numbers.Push(num);
            }

            return numbers;
        }

        private static void PrintTotalSumFromNumbers(Stack<int> numbers)
        {
            int sum = numbers.ToArray().Sum();
            Console.WriteLine($"Sum: {sum}");
        }

        private static Stack<int> RemoveElements(Stack<int> numbers, int removeElements)
        {
            if(numbers.Count >= removeElements)
            {
                while (removeElements > 0)
                {
                    numbers.Pop();
                    removeElements--;
                }
            }
          
            return numbers;
        }
    }
}
