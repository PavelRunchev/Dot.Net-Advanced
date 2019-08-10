using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class StartUp
    {
        static void Main()
        {
            SortedSet<Person> persons = new SortedSet<Person>();
            HashSet<Person> people = new HashSet<Person>();
            int countPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < countPeople; i++)
            {
                string[] inputPerson = Console.ReadLine().Split();
                string name = inputPerson[0];
                int age = int.Parse(inputPerson[1]);
                Person person = new Person(name, age);
                persons.Add(person);
                people.Add(person);
            }

            Console.WriteLine(persons.Count);
            Console.WriteLine(people.Count);
        }
    }
}
