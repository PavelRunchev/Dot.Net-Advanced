using System;
using System.Linq;

namespace Miner
{
    class Miner
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[][] matrix = new char[matrixSize][];
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray().Where(a => a != ' ').ToArray();
            }

            foreach (string command in commands)
            {
                int[] startPosition = GetPosition(matrix, 's');
                if(startPosition.Length == 2)
                {
                    int startRow = startPosition[0];
                    int startCol = startPosition[1];
                    int row = startRow;
                    int col = startCol;
                   
                    switch (command)
                    {
                        case "up":
                            row = startRow - 1;
                            break;
                        case "down":
                            row = startRow + 1;
                            break;
                        case "left":
                            col = startCol - 1;
                            break;
                        case "right":
                            col = startCol + 1;
                            break;
                    }

                    if (!InMatrix(row, col, matrix.Length))
                    {
                        continue;
                    }
                    else
                        matrix[startRow][startCol] = '*';

                    char currentPosition = matrix[row][col];
                    if (currentPosition == 'e')
                    {
                        Console.WriteLine($"Game over! ({row}, {col})");
                        return;
                    }
                    else if (currentPosition == 'c')
                    {
                        matrix[row][col] = 's';
                    }
                    else if (currentPosition == '*')
                        matrix[row][col] = 's';

                    bool collectedAllCoals = CheckForCoals(matrix);
                    if (collectedAllCoals)
                    {
                        Console.WriteLine($"You collected all coals! ({row}, {col})");
                        return;
                    }
                }               
            }

            int coals = matrix.SelectMany(x => x.Where(a => a == 'c')).ToArray().Count();
            int[] minerPosition = GetPosition(matrix, 's');
            Console.WriteLine($"{coals} coals left. ({minerPosition[0]}, {minerPosition[1]})");
        }

        private static bool CheckForCoals(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'c')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static int[] GetPosition(char[][] matrix, char ch)
        {
            int[] array = new int[2];
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if(matrix[row][col] == ch)
                    {
                        array[0] = row;
                        array[1] = col;
                        return array;
                    }
                }
            }

            return array;
        }

        private static bool InMatrix(int row, int col, int length)
        {
            return row >= 0 && row < length && col >= 0 && col < length;
        }
    }
}
