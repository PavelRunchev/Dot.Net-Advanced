﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    public class Dog : Mammal
    {
        private readonly double increase = 0.40;

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        { }

        public override string ProducingSound()
        {
            return "Woof!";
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
