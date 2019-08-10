using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_FamilyTree
{
    class StartUp
    {
        static List<Person> persons;
        static List<string> relationships;

        static void Main()
        {
            persons = new List<Person>();
            relationships = new List<string>();
            string mainPersonInfo = Console.ReadLine();

            string inputInfo;
            while ((inputInfo = Console.ReadLine()) != "End")
            {
                if (!inputInfo.Contains("-"))
                {
                    string[] info = inputInfo.Split();
                    Person person = new Person($"{info[0]} {info[1]}", info[2]);
                    persons.Add(person);
                }
                else
                    relationships.Add(inputInfo);
            }

            foreach (var member in relationships)
            {
                string[] relationSplit = member.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                string parentName = relationSplit[0];
                string childName = relationSplit[1];

                Person parent = GetPerson(parentName);
                Person child = GetPerson(childName);

                if (!parent.Children.Contains(child))
                    parent.Children.Add(child);

                if (!child.Parents.Contains(parent))
                    child.Parents.Add(parent);
            }

            //Print all info for current person!
            PrintInfoForMainPerson(GetPerson(mainPersonInfo));
        }

        private static void PrintInfoForMainPerson(Person person)
        {
            Console.WriteLine(person.ToString());
            Console.WriteLine(person.PrintParents());
            Console.WriteLine(person.PrintChildren());
        }

        private static Person GetPerson(string name)
        {
            if (name.Contains("/"))
                return persons.FirstOrDefault(p => p.Birthday == name);

            return persons.FirstOrDefault(p => p.Name == name);
        }
    }
}
