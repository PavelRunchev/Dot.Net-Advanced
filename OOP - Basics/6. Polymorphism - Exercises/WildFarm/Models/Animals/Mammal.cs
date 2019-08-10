using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string name, double weight, string livingRegion)
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion
        {
            get => livingRegion;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Living Region cannot be empty!");

                livingRegion = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}";
        }
    }
}
