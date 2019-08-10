using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> data = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if(symbol == '(')
                {
                    data.Push(i);
                }
                else if(symbol == ')')
                {
                    int startIndex = data.Pop();
                    Console.WriteLine(input.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
