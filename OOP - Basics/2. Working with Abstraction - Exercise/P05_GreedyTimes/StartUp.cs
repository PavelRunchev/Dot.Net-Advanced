using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class StartUp
    {
        static void Main()
        {
            long capacity = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Bag bag = new Bag(capacity);

            for (int i = 0; i < safe.Length; i += 2)
            {
                string itemName = safe[i];
                long amount = long.Parse(safe[i + 1]);
                bag.AddItem(itemName, amount);              
            }

            Console.WriteLine(bag.ToString());
        }
    }
}