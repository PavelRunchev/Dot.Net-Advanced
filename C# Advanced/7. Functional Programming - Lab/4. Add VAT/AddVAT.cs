using System;
using System.Linq;

namespace AddVAT
{
    class AddVAT
    {
        static void Main()
        {
            string[] inputDigit = Console.ReadLine()
                .Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(e => e + (e * 0.20))
                .Select(e => $"{e:f2}")
                .ToArray();
            Console.WriteLine(String.Join("\n", inputDigit));
        }
    }
}
