using System;
using System.Collections.Generic;
using System.Text;

namespace P07_FamilyTree
{
    public class Person
    {
        private string name;
        private string birthday;
        private List<Person> parents;
        private List<Person> children;

        public Person(string name, string birthdate) : this()
        {
            this.Name = name;
            this.Birthday = birthdate;
        }

        public Person()
        {
            this.Children = new List<Person>();
            this.Parents = new List<Person>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public List<Person> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public List<Person> Children
        {
            get { return children; }
            set { children = value; }
        }

        public string PrintParents()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Parents:");
            foreach (Person parent in Parents)
                builder.AppendLine($"{parent.Name} {parent.Birthday}");

            return builder.ToString().TrimEnd();
        }

        public string PrintChildren()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Children:");
            foreach (Person child in Children)
                builder.AppendLine($"{child.Name} {child.Birthday}");

            return builder.ToString().TrimEnd();
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Birthday}";
        }
    }
}
