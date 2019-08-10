using System;
using System.Collections.Generic;


namespace TrafficJam
{
    class Program
    {
        static void Main()
        {
            Queue<string> dataCars = new Queue<string>();
            int countPassed = int.Parse(Console.ReadLine());
            string input;
            int count = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                if(input == "green")
                {
                    for (int i = 1; i <= countPassed; i++)
                    {
                        if (dataCars.Count < 1)
                            break;

                        Console.WriteLine($"{dataCars.Dequeue()} passed!");
                        count++;
                    }
                }
                else
                {
                    dataCars.Enqueue(input);
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
