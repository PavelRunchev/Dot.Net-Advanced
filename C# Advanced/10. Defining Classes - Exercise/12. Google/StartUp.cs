using System;
using System.Linq;
using System.Collections.Generic;

namespace Google
{
    public class StartUp
    {
        static void Main()
        {
            List<People> peoples = new List<People>();
            string inputPerson = String.Empty;
            while ((inputPerson = Console.ReadLine()) != "End")
            {
                string[] commands = inputPerson.Split(' ').ToArray();
                string name = commands[0];
                string command = commands[1];
                switch (command) 
                {
                    case "company": peoples = AddCompany(name, command, commands, peoples);
                        break;
                    case "pokemon": peoples = AddPokemon(name, command, commands, peoples);
                        break;
                    case "parents": peoples = AddParents(name, command, commands, peoples);
                        break;
                    case "children": peoples = AddChildren(name, command, commands, peoples);
                        break;
                    case "car": peoples = AddCar(name, command, commands, peoples);
                        break;
                    default: break;

                }
            }

            string findPeople = Console.ReadLine();
            People currentPeople = peoples.FirstOrDefault(p => p.Name == findPeople);
            Console.WriteLine(currentPeople.ToString());
        }

        private static List<People> AddCar(string name, string command, string[] commands, List<People> peoples)
        {
            string carModel = commands[2];
            int carSpeed = int.Parse(commands[3]);
            if (peoples.Any(p => p.Name == name))
            {
                People currentPeople = peoples.FirstOrDefault(p => p.Name == name);             
                if(currentPeople.Car == null)
                {
                    currentPeople.Car = new Car(carModel, carSpeed);
                }
                else
                {
                    currentPeople.Car.Model = carModel;
                    currentPeople.Car.Speed = carSpeed;
                }
            }
            else
            {           
                Car car = new Car(carModel, carSpeed);
                People people = new People(name, car);
                peoples.Add(people);
            }

            return peoples;
        }

        private static List<People> AddChildren(string name, string command, string[] commands, List<People> peoples)
        {
            string childName = commands[2];
            string childBirthday = commands[3];
            if(peoples.Any(p => p.Name == name))
            {
                People currentPeople = peoples.FirstOrDefault(p => p.Name == name);
                Children child = new Children(childName, childBirthday);
                if(currentPeople.Children == null)
                    currentPeople.Children = new List<Children>();

                currentPeople.Children.Add(child);
            }
            else
            {               
                Children child = new Children(childName, childBirthday);
                List<Children> children = new List<Children>();
                children.Add(child);
                People people = new People(name, children);
                peoples.Add(people);
            }

            return peoples;
        }

        private static List<People> AddParents(string name, string command, string[] commands, List<People> peoples)
        {
            string parentName = commands[2];
            string parentBirthday = commands[3];
            if(peoples.Any(p => p.Name == name))
            {
                People currentPeople = peoples.FirstOrDefault(p => p.Name == name);
                if(currentPeople.Parents == null)
                    currentPeople.Parents = new List<Parent>();

                Parent parent = new Parent(parentName, parentBirthday);
                currentPeople.Parents.Add(parent);
            }
            else
            {
                Parent parent = new Parent(parentName, parentBirthday);
                List<Parent> parents = new List<Parent>();
                parents.Add(parent);
                People people = new People(name, parents);
                peoples.Add(people);
            }

            return peoples;
        }

        public static List<People> AddPokemon(string name, string command, string[] commands, List<People> peoples)
        {
            string pokemonName = commands[2];
            string pokemonType = commands[3];
            if (peoples.Any(p => p.Name == name))
            {
                People currentPeople = peoples.FirstOrDefault(p => p.Name == name);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonType);
                if (currentPeople.Pokemons == null)               
                    currentPeople.Pokemons = new List<Pokemon>();             
               
                currentPeople.Pokemons.Add(pokemon);
            }
            else
            {                            
                Pokemon pokemon = new Pokemon(pokemonName, pokemonType);
                List<Pokemon> pokemons = new List<Pokemon>();
                pokemons.Add(pokemon);
                People people = new People(name, pokemons);
                peoples.Add(people);
            }

            return peoples;
        }

        private static List<People> AddCompany(string name, string c, string[] commands, List<People> peoples)
        {
            string companyName = commands[2];
            string department = commands[3];
            decimal salary = decimal.Parse(commands[4]);
            if (peoples.Any(p => p.Name == name))
            {
                People currentPeople = peoples.FirstOrDefault(p => p.Name == name);        
                if (currentPeople.Company == null)
                {
                    currentPeople.Company = new Company(companyName, department, salary);
                }
                else
                {
                    currentPeople.Company.Name = companyName;
                    currentPeople.Company.Department = department;
                    currentPeople.Company.Salary = salary;
                }
            }
            else
            {
                Company company = new Company(companyName, department,salary);
                People people = new People(name, company);
                peoples.Add(people);
            }

            return peoples;
        }
    }
}
