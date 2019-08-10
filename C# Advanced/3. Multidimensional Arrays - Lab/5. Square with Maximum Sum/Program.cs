using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main()
        {
            int[] inputMatrixSizes = Console.ReadLine()
                .Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[,] matrix = new int[inputMatrixSizes[0], inputMatrixSizes[1]];

            //fill Matrix with numbers
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] inputRow = Console.ReadLine()
                    .Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int g = 0; g < matrix.GetLength(1); g++)
                {
                    matrix[i, g] = inputRow[g];
                }
            }

            int[,] biggestSquareMatrix = new int[2,2];
            int[,] squareMatrix = new int[2, 2];
            int row = 0;
            //Get Biggest square matrix 2x2!
            while(row < matrix.GetLength(0) - 1 && row < inputMatrixSizes[0])
            {
                int col = 0;
                while (col < matrix.GetLength(1) - 1)
                {
                    squareMatrix = FillSquareMatrix(matrix, squareMatrix, row , col);
                    int currentSum = GetSumFromMatrix(squareMatrix);
                    int biggestSum = GetSumFromMatrix(biggestSquareMatrix);
                    if (currentSum > biggestSum)
                        biggestSquareMatrix = FillSquareMatrix(squareMatrix, biggestSquareMatrix);

                    col++;
                }

                row++;
            }

            //Print biggest sub matrix 2x2!
            PrintSquareMatrix(biggestSquareMatrix);
        }

        private static int[,] FillSquareMatrix(int[,] matrix, int[,] squareMatrix, int row, int col)
        {
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    squareMatrix[r, c] = matrix[row + r, col + c];
                }
            }

            return squareMatrix;
        }

        private static int[,] FillSquareMatrix(int[,] squareMatrix, int[,] biggestSquareMatrix)
        {
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    biggestSquareMatrix[r, c] = squareMatrix[r, c];
                }
            }

            return biggestSquareMatrix;
        }

        private static void PrintSquareMatrix(int[,] biggestSquareMatrix)
        {
            Console.WriteLine($"{biggestSquareMatrix[0, 0]} {biggestSquareMatrix[0, 1]}");
            Console.WriteLine($"{biggestSquareMatrix[1, 0]} {biggestSquareMatrix[1, 1]}");
            Console.WriteLine(GetSumFromMatrix(biggestSquareMatrix));
        }

        private static int GetSumFromMatrix(int[,] biggestSquareMatrix)
        {
            int sum = 0;
            foreach (var el in biggestSquareMatrix)
                sum += el;

            return sum;
        }
    }
}
