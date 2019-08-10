using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main()
        {
            int[] inputClothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(inputClothes);
            int capacityRack = int.Parse(Console.ReadLine());

            int numberOfRacks = 0;
            int sumOfClothsinTheRacks = 0;
            while(stack.Count > 0)
            {
                if (capacityRack < sumOfClothsinTheRacks + stack.Peek())
                {
                    numberOfRacks++;
                    sumOfClothsinTheRacks = 0;
                    continue;
                }

                sumOfClothsinTheRacks += stack.Pop();
            }

            if (sumOfClothsinTheRacks > 0)
                numberOfRacks++;

            Console.WriteLine(numberOfRacks);
        }
    }
}
