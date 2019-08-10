using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Interfaces;

namespace WildFarm.Models.Animals
{
    public abstract class Feline : Mammal, IFeline
    {
        private string breed;

        public Feline(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get => breed;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Breed cannot be empty!");

                breed = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}";
        }
    }
}
