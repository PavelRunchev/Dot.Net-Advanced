using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Interfaces;

namespace WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        private string name;
        private double weight;
        private int foodEaten;

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty!");

                name = value;
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Weight must be positive number!");

                weight = value;
            }
        }

        public int FoodEaten
        {
            get => foodEaten;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Weight must be positive number!");

                foodEaten = value;
            }
        }

        public virtual void EatFood(double foodQuantity)
        {

        }

        public virtual string ProducingSound()
        {
            return "Hrrrr";
        }
    }
}
