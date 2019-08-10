using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<string> openBreckets = new Stack<string>();

            bool balance = false;
            foreach (char ch in input)
            {
                switch (ch)
                {
                    case '(':
                    case '[':
                    case '{':
                        openBreckets.Push(ch.ToString());
                        break;
                    case ')':
                    case ']':
                    case '}':
                        balance = CheckForOpenBrecket(openBreckets, ch);
                        if (!balance)
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }
            }

            Console.WriteLine(balance ? "YES" : "NO");
        }

        private static bool CheckForOpenBrecket(Stack<string> openBreckets, char ch)
        {
            if(ch == ')')
            {
                if (openBreckets.Count == 0 || openBreckets.Pop() != "(")
                    return false;
            }
            else if (ch == ']')
            {
                if (openBreckets.Count == 0 || openBreckets.Pop() != "[")
                    return false;
            }
            else if (ch == '}')
            {
                if(openBreckets.Count == 0 || openBreckets.Pop() != "{")
                    return false;
            }

            return true;
        }
    }
}
