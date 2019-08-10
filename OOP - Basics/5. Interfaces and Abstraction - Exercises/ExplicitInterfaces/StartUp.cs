using System;
using System.Collections.Generic;
using System.Linq;
using ExplicitInterfaces.Interfaces;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main()
        {
            ICollection<Citizen> peoples = new List<Citizen>();
            string input;
            while ((input = Console.ReadLine()) != "End") 
            {
                string[] arguments = input.Split();
                string name = arguments[0];
                int age = int.Parse(arguments[2]);
                string country = arguments[1];

                if (peoples.Any(a => a.Name == name))
                    continue;

                IPerson person = new Citizen(name, age, country);
                Console.WriteLine(person.GetName());
                IResident resident = new Citizen(name, age, country);
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
