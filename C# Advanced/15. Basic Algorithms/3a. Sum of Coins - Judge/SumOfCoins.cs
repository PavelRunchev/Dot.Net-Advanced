using System;
using System.Collections.Generic;
using System.Linq;
 
public class SumOfCoins
{
    public static void Main(string[] args)
    {
        var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
        var targetSum = 923;
 
        try
        {
            var selectedCoins = ChooseCoins(availableCoins, targetSum);
 
            Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
            foreach (var selectedCoin in selectedCoins)
            {
                Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
 
    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        var choosenCoins = new Dictionary<int, int>();
        int coinIndex = 0;
        int currentSum = 0;
 
        var sortedCoins = coins.OrderByDescending(c => c).ToList();
 
        while (currentSum != targetSum && coinIndex < sortedCoins.Count)
        {
            var currrentCoinValue = sortedCoins[coinIndex];
            var remainingSum = targetSum - currentSum;
            var numberOfCoinsToTake = remainingSum / currrentCoinValue;
 
            if (numberOfCoinsToTake > 0)
            {
                if(!choosenCoins.ContainsKey(currrentCoinValue))
                {
                    choosenCoins.Add(currrentCoinValue, 0);
                }
 
                choosenCoins[currrentCoinValue]=numberOfCoinsToTake;
               
                 
                currentSum += numberOfCoinsToTake * currrentCoinValue;
            }

            coinIndex++;
        }
 
        if(currentSum == targetSum)
        {
            return choosenCoins;
        }
        else
        {
            throw new InvalidOperationException();
        }
    }
}