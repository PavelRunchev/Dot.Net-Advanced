using System;
using System.Linq;
using System.Collections.Generic;

namespace CompanyRoster
{
    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, List<Employee>> departments = new Dictionary<string, List<Employee>>();
            int countEmployee = int.Parse(Console.ReadLine());
            for (int i = 0; i < countEmployee; i++)
            {
                string[] inputEmployee = Console.ReadLine().Split(" ").ToArray();
                string name = inputEmployee[0];
                decimal salary = decimal.Parse(inputEmployee[1]);
                string pos = inputEmployee[2];
                string department = inputEmployee[3];

                string email = "n/a";
                if(inputEmployee.Length > 4)
                {
                    if(inputEmployee[4].Contains("@"))
                    {
                        email = inputEmployee[4];
                    }
                }

                int age = -1;
                if (inputEmployee.Length > 4)
                {
                    int number;
                    if (int.TryParse(inputEmployee[4], out number))
                    {
                        age = number;
                    }
                    if (inputEmployee.Length > 5 && int.TryParse(inputEmployee[5], out number))
                    {
                        age = number;
                    }
                }

                Employee employee = new Employee(name, salary, pos, department, email, age);
                if(!departments.ContainsKey(department))
                {
                    departments.Add(department, new List<Employee>());
                }

                departments[department].Add(employee);
            }

            List<Employee> highest = departments
                .OrderByDescending(e => e.Value.Sum(a => a.Salary))
                .First()
                .Value
                .ToList()
                .OrderByDescending(u => u.Salary)
                .ToList();

            Console.WriteLine($"Highest Average Salary: {highest[0].Department}");
            foreach (Employee emp in highest)
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
            }
        }
    }
}
