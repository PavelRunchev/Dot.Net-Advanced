using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private string engine;
        private string weight;
        private string color;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public string Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Car(string model, string engine, string weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public override string ToString()
        {
            return $"  Weight: {this.weight}\n  Color: {this.color}";
        }
    }
}
