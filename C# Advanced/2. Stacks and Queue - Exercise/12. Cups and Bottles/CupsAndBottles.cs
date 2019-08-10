using System;
using System.Linq;
using System.Collections.Generic;

namespace CupsAndBottles
{
    class CupsAndBottles
    {
        static void Main()
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int water = 0;
            while (cups.Count > 0)
            {
                int currentCup = cups.Peek();
                while (bottles.Count > 0)
                {
                    int currentBottle = bottles.Pop();
                    currentCup -= currentBottle;
                    if (currentCup < 1)
                    {
                        water += Math.Abs(currentCup);
                        cups.Dequeue();
                        break;
                    }
                }

                if (bottles.Count == 0)
                {
                    Console.WriteLine($"Cups: {String.Join(" ", cups)}");
                    Console.WriteLine($"Wasted litters of water: {water}");
                    return;
                }
            }

            Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
            Console.WriteLine($"Wasted litters of water: {water}");
        }
    }
}
