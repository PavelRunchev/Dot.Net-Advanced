using System;
using System.Linq;

namespace KnightGame
{
    class KnightGame
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[][] matrix = new char[matrixSize][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }

            int countRemovedKnights = 0;
            while (true)
            {
                int countAttack = 0;
                int knightRow = -1;
                int knightCol = -1;
                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        char knight = matrix[row][col];
                        if(knight == 'K')
                        {
                            int currentAttack = CheckKnightForAttack(matrix, row, col);
                            if(currentAttack > countAttack)
                            {
                                countAttack++;
                                knightRow = row;
                                knightCol = col;
                            }
                        }                      
                    }
                }

                if (countAttack > 0)
                {
                    matrix[knightRow][knightCol] = '0';
                    countRemovedKnights++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(countRemovedKnights);
        }

        private static int CheckKnightForAttack(char[][] matrix, int row, int col)
        {
            int knightAttack = 0;
            //bottom/right attack
            if(inMatrix(row + 2, col + 1, matrix.Length) && matrix[row + 2][col + 1] == 'K')
            {
                knightAttack++;
            }
            //bottom/left attack
            if (inMatrix(row + 2, col - 1, matrix.Length) && matrix[row + 2][col - 1] == 'K')
            {
                knightAttack++;
            }

            //top/right attack
            if (inMatrix(row - 2, col + 1, matrix.Length) && matrix[row - 2][col + 1] == 'K')
            {
                knightAttack++;
            }
            //top/left attack
            if (inMatrix(row - 2, col - 1, matrix.Length) && matrix[row - 2][col - 1] == 'K')
            {
                knightAttack++;
            }

            //right/top attack
            if (inMatrix(row + 1, col + 2, matrix.Length) && matrix[row + 1][col + 2] == 'K')
            {
                knightAttack++;
            }
            //right/bottom attack
            if (inMatrix(row - 1, col + 2, matrix.Length) && matrix[row - 1][col + 2] == 'K')
            {
                knightAttack++;
            }

            //left/bottom attack
            if (inMatrix(row + 1, col - 2, matrix.Length) && matrix[row + 1][col - 2] == 'K')
            {
                knightAttack++;
            }
            //left/top attack
            if (inMatrix(row - 1, col - 2, matrix.Length) && matrix[row - 1][col - 2] == 'K')
            {
                knightAttack++;
            }

            return knightAttack;
        }

        private static bool inMatrix(int row, int col, int length)
        {
            return row >= 0 && row < length && col >= 0 && col < length;
        }
    }
}
