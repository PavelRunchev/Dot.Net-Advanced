using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Interfaces;

namespace WildFarm.Models.Animals
{
    public abstract class Bird : Animal, IBird
    {
        private double wingSize;

        public Bird(string name, double weight, double wingSize)
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize
        {
            get => wingSize;
            set
            {
                if (value < 0)
                    throw new ArgumentException("WingSize must be positive number!");

                wingSize = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}";
        }
    }
}
