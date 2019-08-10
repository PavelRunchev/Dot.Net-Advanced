using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    public class Cat : Feline
    {
        private readonly double increase = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        { }

        public override string ProducingSound()
        {
            return "Meow";
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
