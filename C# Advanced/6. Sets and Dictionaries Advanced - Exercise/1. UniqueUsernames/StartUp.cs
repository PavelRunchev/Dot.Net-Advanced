using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class StartUp
    {
        static void Main()
        {
            HashSet<string> dataUsernames = new HashSet<string>();
            int countUsername = int.Parse(Console.ReadLine());

            for (int i = 0; i < countUsername; i++)
            {
                string username = Console.ReadLine();
                dataUsernames.Add(username);
            }

            Console.WriteLine(String.Join("\n", dataUsernames));
        }
    }
}
