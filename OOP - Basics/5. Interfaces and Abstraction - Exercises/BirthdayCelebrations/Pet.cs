using System;
using System.Collections.Generic;
using System.Text;
using BirthdayCelebrations.Interfaces;

namespace BirthdayCelebrations
{
    public class Pet : IBirthable
    {
        private string name;
        private string birthdate;

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Birthdate
        {
            get => birthdate;
            set => birthdate = value;
        }
    }
}
