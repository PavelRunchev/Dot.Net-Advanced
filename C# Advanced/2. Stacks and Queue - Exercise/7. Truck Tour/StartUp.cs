using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class StartUp
    {
        static void Main()
        {
            Queue<int[]> petrolPumps = new Queue<int[]>();
            int countPumps = int.Parse(Console.ReadLine());

            for (int i = 0; i < countPumps; i++)
            {
                petrolPumps.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }

            int pumpIndex = 0;
            while (true)
            {
                int totalFuel = 0;
                foreach (int[] pump in petrolPumps)
                {
                    int amountOfPetrol = pump[0];
                    int distanceFromNextPump = pump[1];

                    totalFuel += amountOfPetrol - distanceFromNextPump;
                    if(totalFuel < 0)
                    {
                        pumpIndex++;
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        break;
                    }
                }

                if (totalFuel >= 0) break;
            }

            Console.WriteLine(pumpIndex);
        }
    }
}
