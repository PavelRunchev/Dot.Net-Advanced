using System;
using System.Linq;
using System.Collections.Generic;

namespace QuickSort
{
    public class Quick
    {
        static void Main()
        {
            //*
            //Implementation Quick Sort algorithm numbers in Array!!!
            //*
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine(String.Join(" ", arr));
        }

        private static void QuickSort(int[] arr, int start, int end)
        {
            if (start >= end)
                return;

            if (isSorted(arr))
                return;

            int i = Partition(arr, start, end);

            QuickSort(arr, start, i - 1);
            QuickSort(arr, i + 1, end);

        }

        private static bool isSorted(int[] arr)
        {
            bool isSort = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int el = arr[i];
                if (el > arr[i + 1])
                {
                    isSort = false;
                    break;
                }
            }

            return isSort;
        }

        private static int Partition(int[] arr, int start, int end)
        {
            if (start >= end)
                return start;

            int index = start - 1;
            int lastNumber = arr[end];
            for (int g = start; g <= end - 1; g++)
            {
                int currElement = arr[g];

                if (currElement <= lastNumber)
                {
                    index++;
                    arr[g] = arr[index];
                    arr[index] = currElement;
                }
            }

            //Swap first element with last!
            arr = Swap(arr, index + 1, end);
            return index + 1;
        }

        private static int[] Swap(int[] arr, int start, int end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            return arr;
        }
    }
}
