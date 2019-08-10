using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, string> dataContest = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();

            string inputContest;
            while ((inputContest = Console.ReadLine()) != "end of contests")
            {
                string[] arguments = inputContest.Split(":");
                string contestName = arguments[0];
                string contestPassword = arguments[1];
                if (!dataContest.ContainsKey(contestName))
                {
                    dataContest.Add(contestName, contestPassword);
                }
            }

            string inputExam;
            while ((inputExam = Console.ReadLine()) != "end of submissions")
            {
                string[] arguments = inputExam.Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries);
                string content = arguments[0];
                string contentPassword = arguments[1];
                string studentName = arguments[2];
                int point = int.Parse(arguments[3]);

                if (dataContest.ContainsKey(content))
                {
                    if(dataContest[content] == contentPassword)
                    {
                        if (!students.ContainsKey(studentName))
                        {
                            students.Add(studentName, new Dictionary<string, int>());

                            if(!students[studentName].ContainsKey(content))
                                students[studentName].Add(content, point);
                            else
                            {
                                if (students[studentName][content] < point)
                                    students[studentName][content] = point;
                            }
                        }
                        else
                        {
                            if(!students[studentName].ContainsKey(content))
                            {
                                students[studentName].Add(content, point);
                            }
                            else
                            {
                                if (students[studentName][content] < point)
                                    students[studentName][content] = point;
                            }
                        }
                    }                 
                }
            }

            KeyValuePair<string, Dictionary<string, int>> mostfamousStudent = students
                .OrderByDescending(a => a.Value.Sum(e => e.Value))
                .ToDictionary(k => k.Key, v => v.Value.ToDictionary(c => c.Key, w => w.Value))
                .First();

            if(mostfamousStudent.Key != null)
            {
                int totalPointOfMostFamousStudent = mostfamousStudent.Value.Sum(a => a.Value);
                //Print most famous student by total points
                Console.WriteLine($"Best candidate is {mostfamousStudent.Key} with total {totalPointOfMostFamousStudent} points.");
            }

            Console.WriteLine("Ranking: ");
            foreach (var candidate in students.OrderBy(c => c.Key))
            {
                Console.WriteLine(candidate.Key);
                foreach (var item in candidate.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }        
        }
    }
}
