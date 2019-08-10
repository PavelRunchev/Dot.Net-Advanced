using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] arguments = input.Split(new string[] { ",", " " },StringSplitOptions.RemoveEmptyEntries);
                string shopName = arguments[0];
                string productName = arguments[1];
                double price = double.Parse(arguments[2]);
                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                }

                if (!shops[shopName].ContainsKey(productName))
                {
                    shops[shopName].Add(productName, price);
                }
            }

            PrintShops(shops);
        }

        private static void PrintShops(Dictionary<string, Dictionary<string, double>> shops)
        {
            foreach (var kvp in shops.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach (var pvp in kvp.Value)
                {
                    Console.WriteLine($"Product: {pvp.Key}, Price: {pvp.Value}");
                }
            }
        }
    }
}
