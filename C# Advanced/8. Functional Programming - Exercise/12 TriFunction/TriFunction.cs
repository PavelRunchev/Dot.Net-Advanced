using System;
using System.Linq;

namespace TriFunction
{
    class TriFunction
    {
        static void Main()
        {
            Action<string> printCollection = str => Console.WriteLine(str);
            int larger = int.Parse(Console.ReadLine());
            string[] inputNames = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Func<string, int, bool> nameIsLarger = (name, length) => name.Sum(n => n) >= length;

            Func<string[], Func<string, int, bool>, string> namesFilter = (names, isLargerFilter) =>
            {
                return names.FirstOrDefault(name => nameIsLarger(name, larger));
            };

            printCollection(namesFilter(inputNames, nameIsLarger));
        }
    }
}
