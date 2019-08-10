using System;
using System.Linq;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int[] inputMatrixSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int inputRows = inputMatrixSizes[0];
            int inputCols = inputMatrixSizes[1];
            int[,] matrix = new int[inputRows, inputCols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputRow = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = inputRow[col];
            }

            long biggestSum = int.MinValue;
            int biggestRow = -1;
            int biggestCol = -1;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    long currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if(currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        biggestRow = row;
                        biggestCol = col;
                    }
                }
            }

            //Print matrix 3x3 with biggest sum!
            PrintOutput(matrix, biggestSum, biggestRow, biggestCol);
        }

        private static void PrintOutput(int[,] matrix, long biggestSum, int biggestRow, int biggestCol)
        {
            Console.WriteLine($"Sum = {biggestSum}");
            for (int row = biggestRow; row < biggestRow + 3; row++)
            {
                for (int col = biggestCol; col < biggestCol + 3; col++)
                {
                    Console.Write(col < biggestCol + 3 ? $"{matrix[row, col]} " : $"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
