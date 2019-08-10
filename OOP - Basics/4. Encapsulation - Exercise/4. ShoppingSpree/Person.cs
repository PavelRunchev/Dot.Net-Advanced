using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<string> products;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    Exception err = new ArgumentException("Name cannot be empty");
                    Console.WriteLine(err.Message);
                    Environment.Exit(0);              
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get => money;
            set
            {
                if(value < 0)
                {
                    Exception err = new ArgumentException("Money cannot be negative");
                    Console.WriteLine(err.Message);
                    Environment.Exit(0);
                }

                this.money = value;
            }
        }

        public List<string> Products
        {
            get => products;
            set
            {
                this.products = value;
            }
        }

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<string>();
        }

        public string BuyProduct(Product product)
        {
            if(this.Money < product.Cost)
            {
                return $"{this.Name} can't afford {product.Name}";
            }

            this.Money -= product.Cost;
            this.Products.Add(product.Name);
            return $"{this.Name} bought {product.Name}";
        }

        public override string ToString()
        {
            return this.Products.Count > 0 
                ? $"{this.Name} - {string.Join(", ", this.Products)}" 
                : $"{this.Name} - Nothing bought";
        }
    }
}
