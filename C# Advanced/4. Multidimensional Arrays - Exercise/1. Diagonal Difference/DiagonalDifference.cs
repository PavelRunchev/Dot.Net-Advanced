using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeMatrix, sizeMatrix];

            //fill matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {               
                int[] inputRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < inputRow.Length; col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            int primaryDiagonal = GetSumPrimaryDiagonal(matrix);
            int secondaryDiagonal = GetSumSecondaryDiagonal(matrix);
            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));              
        }

        private static int GetSumSecondaryDiagonal(int[,] jaggedArray)
        {
            int sum = 0;
            for (int row = 0; row < jaggedArray.GetLength(0) ; row++)
            {
                for (int col = jaggedArray.GetLength(0) - 1; col >= 0; col--)
                {
                    if(jaggedArray.GetLength(1) - 1 - col == row)
                        sum += jaggedArray[row, col];
                }
            }
           
            return sum;
        }

        private static int GetSumPrimaryDiagonal(int[,] jaggedArray)
        {
            int sum = 0;
            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                for (int col = 0; col < jaggedArray.GetLength(1); col++)
                {
                    if (row == col)
                        sum += jaggedArray[row, col];
                }
            }

            return sum;
        }
    }
}
