using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        private readonly double increase = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed)
           : base(name, weight, livingRegion, breed)
        { }

        public override string ProducingSound()
        {
            return "ROAR!!!";
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
