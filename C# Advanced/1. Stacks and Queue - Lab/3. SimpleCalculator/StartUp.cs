using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> data = new Stack<string>(input.Reverse());

            while (data.Count > 1)
            {
                int num1 = int.Parse(data.Pop());
                string operation = data.Pop();
                int num2 = int.Parse(data.Pop());
                switch (operation)
                {
                    case "+": data.Push($"{num1 + num2}"); break;
                    case "-": data.Push($"{num1 - num2}"); break;
                }
            }

            Console.WriteLine(data.Pop());
        }
    }
}
