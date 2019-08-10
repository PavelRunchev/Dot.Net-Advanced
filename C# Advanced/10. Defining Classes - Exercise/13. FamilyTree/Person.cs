using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree
{
    public class Person
    {
        private string name;
        private string birthdate;
        private List<Person> parents;
        private List<Person> children;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public string Birthdate
        {
            get { return this.birthdate; }
            set { this.birthdate = value; }
        }

        public List<Person> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }

        public List<Person> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }

        public Person(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
            this.Parents = new List<Person>();
            this.Children = new List<Person>();
        }
    }
}
