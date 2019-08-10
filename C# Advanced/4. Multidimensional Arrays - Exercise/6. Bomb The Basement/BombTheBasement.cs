using System;
using System.Linq;

namespace BombTheBasement
{
    class BombTheBasement
    {
        static void Main()
        {
            //Input data will always be valid coordinates. There is no need to check it explicitly!!!
            int[] inputMatrixSizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[][] matrix = new int[inputMatrixSizes[0]][];
            int[] bombDimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int bombRow = bombDimensions[0];
            int bombCol = bombDimensions[1];
            int bombRadius = bombDimensions[2];

            //fill bomb radius with number 1 in matrix.
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[inputMatrixSizes[1]];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    double point = Math.Sqrt(Math.Pow(row - bombRow, 2) + Math.Pow(col - bombCol, 2));
                    if (point <= bombRadius)
                        matrix[row][col] = 1;
                }
            }

            //initial second matrix and reversed elements in her.
            int[][] orderByDescendingMatrix = new int[inputMatrixSizes[1]][];
            for (int row = 0; row < inputMatrixSizes[1]; row++)
            {
                orderByDescendingMatrix[row] = new int[inputMatrixSizes[0]];               
                for (int col = 0; col < inputMatrixSizes[0]; col++)
                {
                    orderByDescendingMatrix[row][col] = matrix[col][row];
                }

                orderByDescendingMatrix[row] = orderByDescendingMatrix[row].OrderByDescending(x => x).ToArray();
            }

            //Replace first matrix with second ordered matrix!
            for (int row = 0; row < inputMatrixSizes[0]; row++)
            {
                for (int col = 0; col < inputMatrixSizes[1]; col++)
                {
                    matrix[row][col] = orderByDescendingMatrix[col][row];
                }
            }

            //Print first matrix with string Join.
            Console.WriteLine(String.Join("\n", matrix.Select(x => String.Join("", x))));
        }
    }
}
