using System;
using System.Collections.Generic;

namespace SuperMarket
{
    class Program
    {
        static void Main()
        {
            Queue<string> dataCustoms = new Queue<string>();
            string inputName;
            while ((inputName = Console.ReadLine()) != "End")
            {
                if(inputName == "Paid")
                {
                    foreach (var name in dataCustoms)
                    {
                        Console.WriteLine(name);
                    }
                    dataCustoms.Clear();
                }
                else
                {
                    dataCustoms.Enqueue(inputName);
                }
            }

            Console.WriteLine($"{dataCustoms.Count} people remaining.");
        }
    }
}
