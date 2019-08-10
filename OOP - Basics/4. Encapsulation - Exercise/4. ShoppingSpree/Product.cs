using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public string Name
        {
            get => name;
            set {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    Exception err = new ArgumentException("Name cannot be empty");
                    Console.WriteLine(err.Message);
                    Environment.Exit(0);
                }

                this.name = value;
            }
        }

        public decimal Cost
        {
            get => cost;
            set {
                if (value < 0)
                {
                    Exception err = new ArgumentException("Money cannot be negative");
                    Console.WriteLine(err.Message);
                    Environment.Exit(0);
                }

                this.cost = value;
            }
        }

        public Product (string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
