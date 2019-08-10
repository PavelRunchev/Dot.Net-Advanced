using System;
using System.Numerics;

namespace FibonacciWithRecursive
{
    class Fibonacci
    {
        private static BigInteger[] cache;
        static void Main()
        {
            //Because the recursive is a slow process, we use an BigInteger array like cache!
            //return when n difference from 0!
            try
            {
                int n;
                string input = Console.ReadLine();
                if (int.TryParse(input, out int num))
                {
                    n = num;
                }
                else
                {
                    throw new InvalidOperationException("Input don't be integer Number!");
                }

                cache = new BigInteger[n + 1];
                BigInteger result = GetFibonacci(n);
                Console.WriteLine(result);
            }
            catch (InvalidOperationException ie)
            {
                Console.WriteLine(ie.Message);
                Main();
            }
        }

        private static BigInteger GetFibonacci(int n)
        {
            if (cache[n] != 0)
                return cache[n];

            if (n == 0)
                return 0;

            if (n == 1 || n == 2)
                return 1;

            BigInteger a = GetFibonacci(n - 2);
            BigInteger b = GetFibonacci(n - 1);
            cache[n] = a + b;
            return a + b;
        }
    }
}
