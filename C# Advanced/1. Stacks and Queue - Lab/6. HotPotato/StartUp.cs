using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class StartUp
    {
        static void Main()
        {
            List<string> inputchildren = Console.ReadLine().Split().ToList();
            int step = int.Parse(Console.ReadLine());
            Queue<string> children = new Queue<string>(inputchildren);

            while(children.Count > 1)
            {
                for (int i = 1; i < step; i++)
                {
                    children.Enqueue(children.Dequeue());
                }
               
                Console.WriteLine($"Removed {children.Dequeue()}");
            }

            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
