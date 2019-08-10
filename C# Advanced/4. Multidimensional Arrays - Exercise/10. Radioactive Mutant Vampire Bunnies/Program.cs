using System;
using System.Linq;

namespace RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main()
        {
            int[] inputMatrixSizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int matrixRow = inputMatrixSizes[0];
            int matrixCol = inputMatrixSizes[1];
            char[][] matrix = new char[matrixRow][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }

            char[] inputCommands = Console.ReadLine().ToCharArray();
            foreach (char command in inputCommands)
            {
                int[] player = PlayerPosition(matrix);
                int startRow = player[0];
                int startCol = player[1];
                bool isDead = false;
                bool isWon = false;

                int row = startRow;
                int col = startCol;

                switch (command)
                {
                    case 'U': row = startRow - 1; break;
                    case 'D': row = startRow + 1; break;
                    case 'L': col = startCol - 1; break;
                    case 'R': col = startCol + 1; break;
                }

                if (!inMatrix(row, col, matrix.Length, matrix[startRow].Length))
                {
                    matrix[startRow][startCol] = '.';
                    isWon = true;                  
                }
                else
                {
                    matrix[startRow][startCol] = '.';
                    char currentPosition = matrix[row][col];
                    if (currentPosition == 'B')
                        isDead = true;
                    else if (currentPosition == '.')
                        matrix[row][col] = 'P';
                }
           
                //After player move the bunnies is grow.
                char[][] secondMatrix = new char[matrix.Length][];
                secondMatrix = FillMatroxFromMainMatrix(matrix, secondMatrix);

                for (int r = 0; r < matrix.Length; r++)
                {
                    for (int c = 0; c < matrix[r].Length; c++)
                    {
                        char symbol = matrix[r][c];
                        if(symbol == 'B')
                        {
                            int upRowIndex = r - 1;
                            int downRowIndex = r + 1;
                            int leftColIndex = c - 1;
                            int rightColIndex = c + 1;

                            char grow = '\0';
                            if(upRowIndex >= 0 && matrix[upRowIndex][c] != 'B')
                            {
                                grow = secondMatrix[upRowIndex][c];
                                secondMatrix[upRowIndex][c] = 'B';
                                if (grow == 'P')
                                {
                                    isDead = true;
                                }                             
                            }

                            if (downRowIndex < matrix.Length && matrix[downRowIndex][c] != 'B')
                            {
                                grow = secondMatrix[downRowIndex][c];
                                secondMatrix[downRowIndex][c] = 'B';
                                if (grow == 'P')
                                {
                                    isDead = true;
                                }
                            }

                            if (leftColIndex >= 0 && matrix[r][leftColIndex] != 'B')
                            {
                                grow = secondMatrix[r][leftColIndex];
                                secondMatrix[r][leftColIndex] = 'B';
                                if (grow == 'P')
                                {
                                    isDead = true;
                                }
                            }

                            if (rightColIndex < matrix[r].Length && matrix[r][rightColIndex] != 'B')
                            {
                                grow = secondMatrix[r][rightColIndex];
                                secondMatrix[r][rightColIndex] = 'B';
                                if (grow == 'P')
                                {
                                    isDead = true;
                                }
                            }
                        }
                    }
                }

                matrix = FillMatroxFromMainMatrix(secondMatrix, matrix);

                if (isDead)
                {
                    EndProgram(matrix, row, col);
                    return;
                }

                if (isWon)
                {
                    PrintLair(matrix);
                    Console.WriteLine($"won: {startRow} {startCol}");
                    return;
                }
            }
        }

        private static char[][] FillMatroxFromMainMatrix(char[][] firstMatrix, char[][] secondMatrix)
        {
            for (int row = 0; row < firstMatrix.Length; row++)
            {
                if (secondMatrix[row] == null)
                    secondMatrix[row] = new char[firstMatrix[row].Length];

                for (int col = 0; col < firstMatrix[row].Length; col++)
                {
                    secondMatrix[row][col] = firstMatrix[row][col];
                }
            }

            return secondMatrix;
        }

        private static void EndProgram(char[][] matrix, int row, int col)
        {
            PrintLair(matrix);
            Console.WriteLine($"dead: {row} {col}");
        }

        private static void PrintLair(char[][] matrix)
        {
            Console.WriteLine(String.Join("\n", matrix.Select(x => String.Join("", x))));
        }

        private static bool inMatrix(int row, int col, int rowLength, int colLenth)
        {
            return row >= 0 && row < rowLength && col >= 0 && col < colLenth;
        }

        private static int[] PlayerPosition(char[][] matrix)
        {
            int[] array = new int[2];
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if(matrix[row][col] == 'P')
                    {
                        array[0] = row;
                        array[1] = col;
                        return array;
                    }
                }
            }

            return array;
        }
    }
}
