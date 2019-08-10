using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main()
    {
        Dictionary<int, int> dataCoins = new Dictionary<int, int>();
        int[] inputCoins = Console.ReadLine()
             .Split(new string[] { "Coins: ", ",", " " }, StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .OrderByDescending(c => c)
             .ToArray();
        int sum = int.Parse(Console.ReadLine().Split().Skip(1).First());

        int coinIndex = 0;
        int currentSum = 0;
        while(currentSum != sum && coinIndex < inputCoins.Length)
        {
            int currentCoin = inputCoins[coinIndex];
            int remainSum = sum - currentSum;
            int value = remainSum / currentCoin;

            if(value > 0)
            {
                if (!dataCoins.ContainsKey(currentCoin))
                    dataCoins.Add(currentCoin, 0);
                dataCoins[currentCoin] = value;

                currentSum += value * currentCoin;
            }

            coinIndex++;
        }

        if (currentSum == sum)
        {
            Console.WriteLine($"Number of coinsto take: {dataCoins.Sum(v => v.Value)}");
            foreach (var kvp in dataCoins)
            {
                Console.WriteLine($"{kvp.Value} coin(s) with value {kvp.Key}");
            }
        }
        else
            Console.WriteLine("Error");
    }
}