using System;
using System.Collections.Generic;
using System.Text;
using FoodShortage.Interfaces;

namespace FoodShortage
{
    public class Citizen : INames, IIdentifiable, IBirthable, IBuyer
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;
        private int food;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
            this.food = 0;
        }

        public string Name
        {
            get => name;
            private set => name = value;
        }

        public int Age
        {
            get => age;
            private set => age = value;
        }

        public string Id
        {
            get => id;
            private set => id = value;
        }

        public string Birthdate
        {
            get => birthdate;
            private set => birthdate = value;
        }

        public int Food
        {
            get => food;
        }

        public void BuyFood()
        {
            this.food += 10;
        }
    }
}
