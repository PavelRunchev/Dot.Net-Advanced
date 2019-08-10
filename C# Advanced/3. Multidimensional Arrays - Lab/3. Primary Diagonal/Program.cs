using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main()
        {
            int matrixSizes = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSizes, matrixSizes];
           
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] inputRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int g = 0; g < matrix.GetLength(1); g++)
                {
                    matrix[i, g] = inputRow[g];
                }
            }

            int sumDiagonal = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int g = 0; g < matrix.GetLength(1); g++)
                {
                    if (i == g)
                        sumDiagonal += matrix[i, g];
                }
            }

            Console.WriteLine(sumDiagonal);
        }
    }
}
