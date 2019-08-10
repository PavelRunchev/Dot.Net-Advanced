using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldestFamilyMember
{
    public class Family
    {
        private List<Person> members;

        public List<Person> Members
        {
            get => this.members;
            set => this.members = value;
        }

        public void AddMember(Person member)
        {
            if(member == null)
                throw new Exception("This Object is Empty!");

            this.members.Add(member);
        }

        public void GetOldestMember()
        {
            Person oldestMember = this.members.OrderByDescending(m => m.Age).FirstOrDefault();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }

        public Family()
        {
            this.Members = new List<Person>();
        }
    }
}
