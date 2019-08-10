using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public abstract class Car : ICar
    {
        private const string model = "488-Spider";

        public string Model
        {
            get => model;
        }

        public virtual string Brakes()
        {
            return "Brakes!";
        }

        public virtual string Gas()
        {
            return "Gas!";
        }
    }
}
