using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyRoster
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public string Name {
            get => this.name;
            set => this.name = value;
        }

        public decimal Salary
        {
            get => this.salary;
            set => this.salary = value;
        }

        public string Position
        {
            get => this.position;
            set => this.position = value;
        }

        public string Department
        {
            get => this.department;
            set => this.department = value;
        }

        public string Email
        {
            get => this.email;
            set => this.email = value;
        }

        public int Age
        {
            get => this.age;
            set => this.age = value;
        }

        public Employee(string name, decimal salary, string position, string department, string email, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = email;
            this.Age = age;
        }
    }
}
