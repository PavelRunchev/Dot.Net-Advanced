using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTree
{
    class StartUp
    {
        static List<Person> persons;
        static List<string> relationships;

        static void Main()
        {
            persons = new List<Person>();
            relationships = new List<string>();
            string mainpersonInfo = Console.ReadLine();

            string inputInfo;
            while ((inputInfo = Console.ReadLine()) != "End")
            {
                if (!inputInfo.Contains("-"))
                    AddMember(inputInfo);
                else
                    relationships.Add(inputInfo);
            }

            foreach (var member in relationships)
            {
                string[] arguments = member.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                Person parent = GetPerson(arguments[0]);
                Person child = GetPerson(arguments[1]);

                if (!parent.Children.Contains(child))
                    parent.Children.Add(child);

                if (!child.Parents.Contains(parent))
                    child.Parents.Add(parent);
            }

            Print(mainpersonInfo);
        }

        private static void Print(string mainpersonInfo)
        {
            Person mainPerson = GetPerson(mainpersonInfo);
            Console.WriteLine($"{mainPerson.Name} {mainPerson.Birdthdate}");
            Console.WriteLine("Parents:");

            foreach (Person parent in mainPerson.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.Birdthdate}");
            }

            Console.WriteLine("Children:");

            foreach (Person child in mainPerson.Children)
            {
                Console.WriteLine($"{child.Name} {child.Birdthdate}");
            }
        }

        private static Person GetPerson(string input)
        {
            if (input.Contains('/'))
                return persons.FirstOrDefault(p => p.Birdthdate == input);

            return persons.FirstOrDefault(p => p.Name == input);
        }

        private static void AddMember(string inputInfo)
        {
            string[] inputToken = inputInfo.Split(' ');
            string name = $"{inputToken[0]} {inputToken[1]}";
            string date = inputToken[2];
            Person person = new Person(name, date);
            persons.Add(person);
        }
    }
}
