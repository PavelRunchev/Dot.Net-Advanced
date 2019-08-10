using System;
using System.Collections.Generic;
using System.Text;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public int CompareTo(Person otherPerson)
        {
            int result = this.Name.CompareTo(otherPerson.Name);

            if(result == 0)
            {
                int resultAge = this.Age.CompareTo(otherPerson.Age);
                if(resultAge == 0)
                {
                    int resultTown = this.Town.CompareTo(otherPerson.Town);
                    if (resultTown == 0)
                        return 0;

                    return resultTown;
                }

                return resultAge;
            }

            return result;
        }
    }
}
