using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WildFarm.Interfaces;
using WildFarm.Models.Animals;
using WildFarm.Models.Foods;

namespace WildFarm.Core
{
    public class Engine
    {
        private Dictionary<string, List<string>> typeOFFoodsFromAnimals;
        private ICollection<IAnimal> animals;

        public Engine()
        {
            this.typeOFFoodsFromAnimals = new Dictionary<string, List<string>>()
            {
                { "Mouse", new List<string>() { "Vegetable", "Fruit" } },
                { "Cat", new List<string>() { "Vegetable", "Meat" } },
                { "Hen", new List<string>() { "Vegetable", "Fruit", "Meat", "Seeds" }},
                { "Owl", new List<string>() { "Meat"} },
                { "Dog", new List<string>() { "Meat"} },
                { "Tiger", new List<string>() { "Meat"} }
            };

            this.animals = new List<IAnimal>();
        }

        public void Run()
        {
            int index = 0;
            string input;
            string dataTypeAnimal = string.Empty;
            string dataName = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] argument = input.Split();
                    if (index % 2 == 0)
                    {
                        AddedAnimal(argument);

                        //Saves in variables type and name for check to the foods!
                        dataTypeAnimal = argument[0];
                        dataName = argument[1];
                    }
                    else if (index % 2 != 0)
                    {
                        string foodName = argument[0];
                        double foodQuantity = double.Parse(argument[1]);

                       IAnimal currentAnimal = this.animals
                            .FirstOrDefault(a => a.Name == dataName && a.GetType().Name == dataTypeAnimal);
                        if(currentAnimal != null && this.typeOFFoodsFromAnimals.ContainsKey(dataTypeAnimal))
                        {
                            if (this.typeOFFoodsFromAnimals[dataTypeAnimal].Contains(foodName))
                            {
                                currentAnimal.EatFood(foodQuantity);
                            }
                            else
                            {
                                throw new ArgumentException($"{dataTypeAnimal} does not eat {foodName}!");
                            }
                        }
                    }

                    index++;
                }
                catch(ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    index++;
                }             
            }

            PrintAnimals();
        }

        private void PrintAnimals()
        {
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        private void AddedAnimal(string[] argument)
        {
            string type = argument[0];
            string name = argument[1];
            double weight = double.Parse(argument[2]);

            if (type == "Owl")
            {                
                double wingSize = double.Parse(argument[3]);
                Owl owl = new Owl(name, weight, wingSize);
                animals.Add(owl);
                Console.WriteLine(owl.ProducingSound());
            }
            else if(type == "Hen")
            {
                double wingSize = double.Parse(argument[3]);
                Hen hen = new Hen(name, weight, wingSize);
                animals.Add(hen);
                Console.WriteLine(hen.ProducingSound());
            }
            else if(type == "Mouse")
            {
                string livingRegion = argument[3];
                Mouse mouse = new Mouse(name, weight, livingRegion);
                animals.Add(mouse);
                Console.WriteLine(mouse.ProducingSound());
            }
            else if(type == "Dog")
            {
                string livingRegion = argument[3];
                Dog dog = new Dog(name, weight, livingRegion);
                animals.Add(dog);
                Console.WriteLine(dog.ProducingSound());
            }
            else if(type == "Cat")
            {
                string livingRegion = argument[3];
                string breed = argument[4];
                Cat cat = new Cat(name, weight, livingRegion, breed);
                animals.Add(cat);
                Console.WriteLine(cat.ProducingSound());
            }
            else if(type == "Tiger")
            {
                string livingRegion = argument[3];
                string breed = argument[4];
                Tiger tiger = new Tiger(name, weight, livingRegion, breed);
                animals.Add(tiger);
                Console.WriteLine(tiger.ProducingSound());
            }
        }
    }
}
