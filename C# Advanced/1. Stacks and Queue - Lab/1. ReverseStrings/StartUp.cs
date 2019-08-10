using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class StartUp
    {
        static void Main()
        {
            Stack<char> data = new Stack<char>();
            string inputText = Console.ReadLine();

            foreach (char symbol in inputText)
            {
                data.Push(symbol);
            }


            foreach (char s in data)
            {
                Console.Write(s);
            }

            Console.WriteLine();
        }
    }
}
