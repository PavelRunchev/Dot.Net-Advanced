using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int countClothes = int.Parse(Console.ReadLine());

            for (int i = 0; i < countClothes; i++)
            {
                string[] inputCloth = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = inputCloth[0];

                if (!wardrobe.ContainsKey(color))
                    wardrobe.Add(color, new Dictionary<string, int>());

                for (int g = 1; g < inputCloth.Length; g++)
                {
                    string cloth = inputCloth[g];
                    if (!wardrobe[color].ContainsKey(cloth))
                        wardrobe[color].Add(cloth, 0);

                    wardrobe[color][cloth]++;
                }                        
            }

            string[] lookingFor = Console.ReadLine().Split();
            string lookingForColor = lookingFor[0];
            string lookingForCloth = lookingFor[1];

            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var cloth in kvp.Value)
                {
                    if (kvp.Key == lookingForColor && cloth.Key == lookingForCloth)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
