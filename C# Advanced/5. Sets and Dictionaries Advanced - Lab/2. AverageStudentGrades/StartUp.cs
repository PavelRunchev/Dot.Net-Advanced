using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageStudentGrades
{
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int countStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < countStudents; i++)
            {
                string[] inputStudent = Console.ReadLine().Split();
                string name = inputStudent[0];
                double grade = double.Parse(inputStudent[1]);
                if (!students.ContainsKey(name))
                    students.Add(name, new List<double>());

                students[name].Add(grade);
            }

            foreach (var kvp in students)
            {
                double averageGrades = kvp.Value.Average(x => x);
                string grades = GetGrades(kvp.Value);
                Console.WriteLine($"{kvp.Key} -> {grades} (avg: {averageGrades:f2})");
            }
        }

        private static string GetGrades(List<double> grades)
        {
            StringBuilder builder = new StringBuilder();
            foreach (double grade in grades)
            {
                builder.Append($"{grade:f2} ");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
