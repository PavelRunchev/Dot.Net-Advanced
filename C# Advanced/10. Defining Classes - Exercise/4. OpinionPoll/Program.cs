using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPoll
{
    class Program
    {
        static void Main()
        {
            List<Person> peoples = new List<Person>();
            int countPeaple = int.Parse(Console.ReadLine());
            for (int i = 0; i < countPeaple; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                peoples.Add(person);
            }

            List<Person> personUp30Years = peoples
                .Where(p => p.Age > 30)
                .OrderBy(a => a.Name)
                .ToList();
            foreach (var per in personUp30Years)
            {
                Console.WriteLine($"{per.Name} - {per.Age}");
            }
        }
    }
}
