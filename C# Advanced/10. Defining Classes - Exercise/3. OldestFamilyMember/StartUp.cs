using System;
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    class StartUp
    {
        static void Main()
        {
            int countOfMembers = int.Parse(Console.ReadLine());
            Family members = new Family();
            for (int i = 0; i < countOfMembers; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Person person = new Person(input[0], int.Parse(input[1]));
                members.AddMember(person);
            }

            members.GetOldestMember();
        }
    }
}
