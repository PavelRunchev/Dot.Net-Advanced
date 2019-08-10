using System;
using System.Linq;

namespace Bomb
{
    class Bomb
    {
        static void Main()
        {
            int inputSquareMatrixSize = int.Parse(Console.ReadLine());
            int[][] matrix = new int[inputSquareMatrixSize][];

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] inputRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                matrix[row] = new int[inputSquareMatrixSize];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = inputRow[col];
                }
            }

            string[] inputBombCoordinates = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < inputBombCoordinates.Length; i++)
            {
                int[] bombCoordinate = inputBombCoordinates[i]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int bombRow = bombCoordinate[0];
                int bombCol = bombCoordinate[1];

                if (!ValidCoordinates(bombRow, bombCol, matrix.Length)) continue;

                int bomb = matrix[bombRow][bombCol];
                if (bomb <= 0)
                    continue;

                int startRow = bombRow - 1;
                int startCol = bombCol - 1;
                int endRow = bombRow + 1;
                int endCol = bombCol + 1;

                if (startRow < 0)
                    startRow = 0;
                if (startCol < 0)
                    startCol = 0;
                if (endRow > matrix.Length - 1)
                    endRow = matrix.Length - 1;
                if (endCol > matrix.Length - 1)
                    endCol = matrix.Length - 1;
                for (int row = startRow; row <= endRow; row++)
                {
                    for (int col = startCol; col <= endCol; col++)
                    {
                        int currentCell = matrix[row][col];

                        if(bombRow == row && bombCol == col)
                        {
                            matrix[row][col] = 0;
                            continue;
                        }

                        if(currentCell <= 0)
                            continue;

                        matrix[row][col] -= bomb;
                    }
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[][] matrix)
        {
            int countAliveCells = matrix.SelectMany(e => e.Where(a => a > 0)).ToArray().Count();
            int sum = matrix.Sum(e => e.Where(x => x > 0).ToArray().Sum());

            Console.WriteLine($"Alive cells: {countAliveCells}");
            Console.WriteLine($"Sum: {sum}");

            Console.WriteLine(String.Join("\n", matrix.Select(e => String.Join(" ", e))));
        }

        private static bool ValidCoordinates(int bombRow, int bombCol, int length)
        {
            return bombRow >= 0 && bombRow < length && bombCol >= 0 && bombCol < length;
        }
    }
}
