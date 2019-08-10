using System;
using System.Collections.Generic;


namespace ComparingObjects
{
    class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            string input;
            while((input = Console.ReadLine()) != "END")
            {
                string[] inputPersons = input.Split();
                string name = inputPersons[0];
                int age = int.Parse(inputPersons[1]);
                string town = inputPersons[2];
                Person person = new Person(name, age, town);
                people.Add(person);
            }

            int n = int.Parse(Console.ReadLine());
            Person targetPerson = people[n - 1];

            int personMatches = 0;
            int notEqualPeople = 0;
            foreach (var p in people)
            {
                if (p.CompareTo(targetPerson) == 0)
                {
                    personMatches++;
                }
                else
                {
                    notEqualPeople++;
                }
            }

            //set to one , why not compare itself
            if (personMatches == 1)
                Console.WriteLine("No matches");
            else
                Console.WriteLine($"{personMatches} {notEqualPeople} {people.Count}");
        }
    }
}
