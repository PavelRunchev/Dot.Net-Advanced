using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Children
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

        public Children(string childName, string childBirthday)
        {
            this.Name = childName;
            this.Birthday = childBirthday;
        }

        public override string ToString()
        {
            return $"{this.name} {this.Birthday}";
        }
    }
}
