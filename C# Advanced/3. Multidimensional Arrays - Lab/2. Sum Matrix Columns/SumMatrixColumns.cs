using System;
using System.Linq;

namespace SumMatrixColumns
{
    class SumMatrixColumns
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

            //Sum Column and Print
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int sum = 0;
                for (int g = 0; g < matrix.GetLength(0); g++)
                {
                    sum += matrix[g, i];
                }
                Console.WriteLine(sum);
            }         
        }
    }
}
