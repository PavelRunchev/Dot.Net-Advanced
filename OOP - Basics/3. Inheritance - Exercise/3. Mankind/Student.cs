using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Mankind
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get => facultyNumber;
            set
            {
                if (!Regex.IsMatch(value, @"^([A-Za-z0-9]{5,10})$"))
                    throw new ArgumentException("Invalid faculty number!");

                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder build = new StringBuilder();
            return build.Append(base.ToString())
                .AppendLine($"Faculty number: {this.FacultyNumber}").ToString();
        }
    }
}
