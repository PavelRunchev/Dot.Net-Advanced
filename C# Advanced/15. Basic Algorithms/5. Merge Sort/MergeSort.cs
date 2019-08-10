using System;
using System.Linq;

namespace MergeSort
{
    class MergeSort
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            MergeSorted(arr, 0, arr.Length - 1);
            Console.WriteLine(String.Join(" ", arr));
        }

        private static void MergeSorted(int[] arr, int start, int end)
        {
            if(start < end)
            {
                int middle = (start + end) / 2;

                MergeSorted(arr, start, middle);
                MergeSorted(arr, middle + 1, end);

                Merge(arr, start, middle, end);
            }
        }

        private static void Merge(int[] arr, int start, int middle, int end)
        {
            int[] leftArray = new int[middle - start + 1];
            int[] rightArray = new int[end - middle];

            Array.Copy(arr, start, leftArray, 0, middle - start + 1);
            Array.Copy(arr, middle + 1, rightArray, 0, end - middle);

            int i = 0;
            int j = 0;
            for (int k = start; k < end + 1; k++)
            {
                if(i == leftArray.Length)
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                else if(j == rightArray.Length)
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else if(leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
            }
        }
    }
}
