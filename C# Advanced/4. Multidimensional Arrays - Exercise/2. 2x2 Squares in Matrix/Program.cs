using System;
using System.Linq;

namespace _2x2SquaresInMatrix
{
    class Program
    {
        static void Main()
        {
            int[] inputMatrixSizes = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] matrix = new char[inputMatrixSizes[0], inputMatrixSizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] inputRow = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int c = 0; c < inputRow.Length; c++)
                {
                    matrix[row, c] = inputRow[c];
                }
            }

            int founded = 0;
            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    char symbol = matrix[r, c];
                    if (symbol == matrix[r, c + 1] && symbol == matrix[r + 1, c] 
                        && symbol == matrix[r + 1, c + 1])
                        founded++;
                }
            }

            Console.WriteLine(founded);
        }
    }
}
