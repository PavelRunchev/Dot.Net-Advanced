using System;
using System.Linq;

namespace KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main()
        {
            Action<string[]> sir = honor => Console.WriteLine(String.Join(Environment.NewLine, honor.Select(x => x = "Sir " + x ).ToArray())); ;
            string[] inputNames = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            sir(inputNames);
        }
    }
}
