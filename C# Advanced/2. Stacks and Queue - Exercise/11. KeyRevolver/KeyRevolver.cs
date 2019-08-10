using System;
using System.Linq;
using System.Collections.Generic;

namespace KeyRevolver
{
    class KeyRevolver
    {
        static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] inputBullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputLocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfIntelligence = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(inputBullets.ToArray());
            Queue<int> safeLocks = new Queue<int>(inputLocks.ToArray());

            int bulletsShooted = 0;
            int bulletCount = 0;
            while(safeLocks.Count > 0)
            {
                int currentLock = safeLocks.Peek();
                while (bullets.Count > 0)
                {
                    if(bulletCount == gunBarrelSize)
                    {
                        Console.WriteLine("Reloading!");
                        bulletCount = 0;
                    }

                    int currentBullet = bullets.Pop();
                    bulletCount++;
                    bulletsShooted++;
                    if(currentBullet <= currentLock)
                    {
                        Console.WriteLine("Bang!");
                        safeLocks.Dequeue();
                        break;
                    }
                    else if(currentBullet > currentLock)
                    {
                        Console.WriteLine("Ping!");
                    }                    
                }

                if(bullets.Count == 0 && safeLocks.Count > 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {safeLocks.Count}");
                    return;
                }
                   

                if (bulletCount == gunBarrelSize && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    bulletCount = 0;
                }
            }

            int earned = valueOfIntelligence - (bulletPrice * bulletsShooted);
            Console.WriteLine($"{bullets.Count} bullets left. Earned ${earned}");
        }
    }
}
