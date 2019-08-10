using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Invalid input!");

                name = value;
            }
        }

        public int Age
        {
            get => age;
            private set
            {
                if(value < 0)
                    throw new ArgumentException("Invalid input!");

                age = value;
            }
        }

        public string Gender
        {
            get => gender;
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Invalid input!");

                gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return "grrrrrr";
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Gender}";
        }
    }
}
