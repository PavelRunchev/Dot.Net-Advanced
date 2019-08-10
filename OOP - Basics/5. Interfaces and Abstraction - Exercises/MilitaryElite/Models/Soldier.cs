using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public abstract class Soldier : ISoldier
    {
        private int id;
        private string firstName;
        private string lastName;

        public Soldier(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get => id;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Id must be positive number!");

                id = value;
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("First name cannot be empty!");

                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Last name cannot be empty!");

                lastName = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }
    }
}
