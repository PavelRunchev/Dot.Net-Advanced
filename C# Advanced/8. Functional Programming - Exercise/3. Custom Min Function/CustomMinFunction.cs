using System;
using System.Linq;

namespace CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main()
        {
            Action<int> printMinElement = el => Console.WriteLine(el);

            Func<int[], int> getMinElement = numbers =>
            {
                int minValue = int.MaxValue;
                foreach (int num in numbers)
                {
                    if (num < minValue)
                        minValue = num;
                }

                return minValue;
            };

            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            printMinElement(getMinElement(inputNumbers));          
        }
    }
}
