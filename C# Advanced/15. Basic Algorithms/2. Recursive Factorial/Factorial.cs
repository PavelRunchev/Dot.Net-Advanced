using System;
using System.Numerics;

namespace RecursiveFactorial
{
    class Factorial
    {
        static void Main()
        {
            try
            {
                BigInteger n;
                string input = Console.ReadLine();
                if (BigInteger.TryParse(input, out BigInteger num))
                {
                    n = num;
                }
                else
                {
                    throw new InvalidOperationException("Input don't be integer Number!");
                }

                BigInteger result = GetFactorial(n);
                Console.WriteLine(result);
            }
            catch(InvalidOperationException ie)
            {
                Console.WriteLine(ie.Message);
                Main();
            }           
        }

        private static BigInteger GetFactorial(BigInteger n)
        {
            if (n < 0)
                throw new InvalidOperationException("Digit must be positive Number!");

            if (n == 1 || n == 0)
                return 1;

            BigInteger currentN = n;
            BigInteger next = GetFactorial(n - 1);
            BigInteger result = currentN * next;
            return result;
        }
    }
}
