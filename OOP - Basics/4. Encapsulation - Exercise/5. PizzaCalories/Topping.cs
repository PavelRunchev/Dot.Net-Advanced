using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Topping
    {
        private const int caloriesPerGram = 2;
        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        private string Type
        {
            get => type;
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies"
                    && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        private int Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public double ToppingCalories()
        {
            double typeGram = 0;
            switch (this.type.ToLower())
            {
                case "meat": typeGram = 1.2; break;
                case "veggies": typeGram = 0.8; break;
                case "cheese": typeGram = 1.1; break;
                case "sauce": typeGram = 0.9; break;
            }

            return typeGram * this.weight * caloriesPerGram;
        }
    }
}
