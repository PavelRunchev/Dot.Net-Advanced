using System;
using System.Linq;

namespace BinrySearch
{
    class BinarySearch
    {
        static void Main()
        {
            //Not implement sort numbers in array, input will only sorted array from numbers by condition!
            int[] numbersArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int searchElement = int.Parse(Console.ReadLine());

            int result = BinarySearchMethod(numbersArray, searchElement);
            Console.WriteLine(result);
        }

        private static int BinarySearchMethod(int[] numbersArray, int searchElement)
        {
            int start = 0, end = numbersArray.Length - 1;
            while (start <= end)
            {
                //divide half array part!
                int middle = (start + end) / 2;

                if (searchElement > numbersArray[middle])
                {
                    start = middle + 1;
                }
                else if(searchElement < numbersArray[middle])
                {
                    end = middle - 1;
                }
                else
                {
                    //its found!
                    return middle;
                }
            }

            //If not found search number will return -1!
            return -1;
        }
    }
}
