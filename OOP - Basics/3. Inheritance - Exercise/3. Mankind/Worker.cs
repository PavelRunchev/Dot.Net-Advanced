using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
     class Worker : Human
    {
        private decimal weekSalary;
        private decimal hoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal hoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.HoursPerDay = hoursPerDay;
        }

        internal decimal WeekSalary
        {
            get => weekSalary;
            set
            {
                if (value <= 10)
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                weekSalary = value;
            }
        }

        internal decimal HoursPerDay
        {
            get => hoursPerDay;
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                hoursPerDay = value;
            }
        }

        internal decimal SalaryPerHour()
        {
            return (this.WeekSalary / 5m) / this.HoursPerDay;
        }

        public override string ToString()
        {
            StringBuilder build = new StringBuilder();
            return build.Append(base.ToString())
                .AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Hours per day: {this.HoursPerDay:f2}")
                .AppendLine($"Salary per hour: {this.SalaryPerHour():f2}")
                .ToString();
        }
    }
}
