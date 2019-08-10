using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FoodShortage.Interfaces;

namespace FoodShortage.Core
{
    public class Engine
    {
        private ICollection<IBuyer> peoples;

        public Engine()
        {
            this.peoples = new List<IBuyer>();
        }
        public void Run()
        {
            int numberOfPeoples = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPeoples; i++)
            {
                string[] argument = Console.ReadLine().Split();
                string name = argument[0];
                int age = int.Parse(argument[1]);

                if (argument.Length == 3 && !this.peoples.Any(p => p.Name == name))
                {
                    IBuyer rebel = new Rebel(name, age, argument[2]);
                    peoples.Add(rebel);
                }
                else if(argument.Length == 4 && !this.peoples.Any(p => p.Name == name))
                {
                    string id = argument[2];
                    string birthdate = argument[3];
                    IBuyer citizen = new Citizen(name, age, id, birthdate);
                    peoples.Add(citizen);
                }
            }

            string inputName;
            while ((inputName = Console.ReadLine()) != "End")
            {
                IBuyer currentPeople = this.peoples.FirstOrDefault(p => p.Name == inputName);
                if (currentPeople != null)
                    currentPeople.BuyFood();
            }

            printTotalPointFromFoods();
        }

        private void printTotalPointFromFoods()
        {
            int totalPointsFromFood = this.peoples.Sum(p => p.Food);
            Console.WriteLine(totalPointsFromFood);
        }
    }
}
