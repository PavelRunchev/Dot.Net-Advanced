using System;
using System.Linq;

namespace Froggy
{
    class StartUp
    {
        static void Main()
        {
            int[] inputStones = Console.ReadLine()
                .Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(inputStones);

            Console.WriteLine(String.Join(", ", lake));         
        }
    }
}
