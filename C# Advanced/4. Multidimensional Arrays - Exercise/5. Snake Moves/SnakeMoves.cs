using System;
using System.Linq;

namespace SnakeMoves
{
    class SnakeMoves
    {
        static void Main()
        {
            string[] inputMatrixSizes = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (inputMatrixSizes.Length == 0)
                return;

            int inputRow = int.Parse(inputMatrixSizes[0]);
            int inputCol = int.Parse(inputMatrixSizes[1]);
            char[,] matrix = new char[inputRow, inputCol];
            string snake = Console.ReadLine();

            int index = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (index == snake.Length)
                        index = 0;

                    matrix[row, col] = snake[index++];
                }
            }

            //Print Matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
