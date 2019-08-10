using System;
using System.Linq;

namespace RecursiveArraySum
{
    class StartUp
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = Sum(array);

            Console.WriteLine(result);
        }

        private static int Sum(int[] array, int index = 0)
        {
            if (index == array.Length)
                return 0;

            int firstSum = array[index];
            int arraySum = Sum(array, ++index);
            return firstSum + arraySum;
        }
    }
}
