using System;
using System.Linq;


namespace PredicateForNames
{
    class PredicateForNames
    {
        static void Main()
        {
            int namesLength = int.Parse(Console.ReadLine());
            Action<string[]> printArray = names => Console.WriteLine(string.Join(Environment.NewLine, names));
            Predicate<string> func = x => x.Length <= namesLength;

            string[] inputNames = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => func(x))
                .ToArray();
            printArray(inputNames);
        }
    }
}
