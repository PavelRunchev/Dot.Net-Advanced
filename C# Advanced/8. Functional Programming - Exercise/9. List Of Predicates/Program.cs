using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOfPredicates
{
    class Program
    {
        static void Main()
        {
            Action<List<int>> printList = arr => Console.WriteLine(string.Join(" ", arr));
            Func<int, int[]> fillArray = uppRange =>
            {
                int[] array = new int[uppRange];
                for (int i = 0; i < uppRange; i++)
                    array[i] = i + 1;

                return array;
            };

            Func<int[], int[], List<int>> filtredArrayByDividers = (arr, dividers) =>
            {
                  List<int> list = new List<int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    bool divide = true;
                    for (int g = 0; g < dividers.Length; g++)
                    {
                        if (arr[i] % dividers[g] != 0)
                        { 
                            divide = false;
                            break;
                        }
                    }

                    if (divide)
                        list.Add(arr[i]);
                }

                  return list;
            };

            int range = int.Parse(Console.ReadLine());
            int[] deviders = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = fillArray(range);
            List<int> result = filtredArrayByDividers(numbers, deviders);
            printList(result);
        }
    }
}
