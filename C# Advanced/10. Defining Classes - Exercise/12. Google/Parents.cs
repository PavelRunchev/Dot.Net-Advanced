﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Parent
    {
        private string name;
        private string birthday;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }

        public Parent(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public override string ToString()
        {
            return $"{this.name} {this.Birthday}";
        }
    }
}
