using System;
using System.Collections.Generic;
using System.Linq;

namespace RecordUniqueNames
{
    class StartUp
    {
        static void Main()
        {
            HashSet<string> data = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string inputName = Console.ReadLine();
                data.Add(inputName);
            }


            Console.WriteLine(String.Join("\n", data));
        }
    }
}
