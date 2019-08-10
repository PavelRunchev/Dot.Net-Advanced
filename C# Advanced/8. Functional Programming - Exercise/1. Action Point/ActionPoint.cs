using System;

namespace ActionPoint
{
    class ActionPoint
    {
        static void Main()
        {
            Action<string[]> printNames = (names) => Console.WriteLine(String.Join(Environment.NewLine, names)); ;

            printNames(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
