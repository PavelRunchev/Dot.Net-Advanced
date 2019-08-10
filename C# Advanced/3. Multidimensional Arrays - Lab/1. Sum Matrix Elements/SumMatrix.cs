using System;
using System.Linq;

namespace SumMatrixElements
{
    class SumMatrix
    {
        static void Main()
        {
            int[] inputMatrixSizes = Console.ReadLine()
                .Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[inputMatrixSizes[0], inputMatrixSizes[1]];

            for (int i = 0; i < inputMatrixSizes[0]; i++)
            {
                int[] inputRow = Console.ReadLine()
                    .Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int g = 0; g < inputRow.Length; g++)
                {
                    matrix[i, g] = inputRow[g];
                }
            }

            int sum = 0;
            foreach (var el in matrix)
            {
                sum += el;
            }                                           

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
