using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Car
    {
        private string model;
        private int speed;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public Car (string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        public override string ToString()
        {
            return $"{this.model} {this.speed}";
        }
    }
}
