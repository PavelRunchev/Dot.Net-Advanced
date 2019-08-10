using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, List<string>>> data = new Dictionary<string, Dictionary<string, List<string>>>();
            int countInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < countInput; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continentName = input[0];
                string country = input[1];
                string city = input[2];
                if (!data.ContainsKey(continentName))
                {
                    data.Add(continentName, new Dictionary<string, List<string>>());
                }

                if (!data[continentName].ContainsKey(country))
                {
                    data[continentName].Add(country, new List<string>());
                }

                data[continentName][country].Add(city);
            }

            PrintAllCities(data);
        }

        private static void PrintAllCities(Dictionary<string, Dictionary<string, List<string>>> data)
        {
            foreach (var kvp in data)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var cvc in kvp.Value)
                {
                    Console.WriteLine($"  {cvc.Key} -> {String.Join(", ", cvc.Value)}");
                }
            }
        }
    }
}
