using System;
using System.Linq;
using System.Collections.Generic;

namespace CountUppercaseWords
{
    class CountUppercaseWords
    {
        static void Main()
        {
            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(e => Char.IsUpper(e[0]))
                .ToList()
                .ForEach(e => Console.WriteLine(e));
        }
    }
}
