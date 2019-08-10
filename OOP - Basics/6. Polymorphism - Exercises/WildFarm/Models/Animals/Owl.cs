using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    public class Owl : Bird
    {
        private readonly double increase = 0.25;

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        { }

        public override string ProducingSound()
        {
            return "Hoot Hoot";
        }

        public override void EatFood(double foodQuantity)
        {
            this.FoodEaten += (int)foodQuantity;
            this.Weight += (foodQuantity * this.increase);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{base.ToString()}]";
        }
    }
}
