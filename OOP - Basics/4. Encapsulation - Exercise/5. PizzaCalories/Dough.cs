using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const double caloeriesPerGram = 2;

        private string type;
        private string baking;
        private int weight;

        public Dough(string type, string baking, int weight)
        {
            this.Type = type;
            this.Baking = baking;
            this.Weight = weight;
        }

        private string Type
        {
            get => type;
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                   throw new ArgumentException("Invalid type of dough.");
                }

                this.type = value;
            }
        }

        private string Baking
        {
            get => baking;
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.baking = value;
            }
        }

        private int Weight
        {
            get => this.weight;
            set
            {
                if(value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double DoughCalories()
        {
            double flourType = this.type.ToLower() == "white" ? 1.5 : 1.0;
            double backingTechnique = this.baking.ToLower() == "crispy" 
                ? 0.9 : this.baking.ToLower() == "chewy" ? 1.1 : 1.0;

            return this.weight * caloeriesPerGram * flourType * backingTechnique;
        }
    }
}
