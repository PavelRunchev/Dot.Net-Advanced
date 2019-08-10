using System;
using System.Linq;
using System.Collections.Generic;

namespace FilterByAge
{
    class FilterByAge
    {
        static void Main()
        {
            Dictionary<string, int> peoples = new Dictionary<string, int>();
            int countNamesInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < countNamesInput; i++)
            {
                string[] inputPeople = Console.ReadLine()
                    .Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputPeople[0];
                int age = int.Parse(inputPeople[1]);
                if (!peoples.ContainsKey(name))
                    peoples.Add(name, age);
            }

            string condition = Console.ReadLine();
            int conditionAge = int.Parse(Console.ReadLine());
            string[] conditionOutput = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if(condition == "younger")
            {
                peoples = peoples.Where(e => e.Value < conditionAge).ToDictionary(k => k.Key, v => v.Value);
            }
            else if(condition == "older")
            {
                peoples = peoples.Where(e => e.Value >= conditionAge).ToDictionary(k => k.Key, v => v.Value);
            }

            PrintOutput(peoples, conditionOutput);
        }

        private static void PrintOutput(Dictionary<string, int> peoples, string[] conditionOutput)
        {
            foreach (var item in peoples)
            {
                if (conditionOutput.Length == 1 && conditionOutput[0] == "name")                                
                        Console.WriteLine($"{item.Key}");             
                else if (conditionOutput.Length == 1 && conditionOutput[0] == "age")              
                        Console.WriteLine($"{item.Value}");              
                else             
                        Console.WriteLine($"{item.Key} - {item.Value}");                
            }
        }
    }
}
