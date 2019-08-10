using System;
using System.Collections.Generic;
using System.Text;
using Animals.Factory;
using Animals;

namespace Animals.Core
{
    public class Engine
    {
        private AnimalFactory animalFactory;
        private List<Animal> animals;

        public Engine()
        {
            this.animalFactory = new AnimalFactory();
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            string inputTypeAnimal;
            while ((inputTypeAnimal = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    string[] inputAnimalInfo = Console.ReadLine().Split();
                    string name = inputAnimalInfo[0];
                    int age = int.Parse(inputAnimalInfo[1]);
                    string gender = inputAnimalInfo[2];
                    Animal animal = animalFactory.CreateAnimal(inputTypeAnimal, name, age, gender);
                    animals.Add(animal);
                }
                catch(ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }              
            }

            Print();
        }

        private void Print()
        {
            foreach(Animal animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name}");
                Console.WriteLine(animal.ToString());
                Console.WriteLine($"{animal.ProduceSound()}");
            }
        }
    }
}
