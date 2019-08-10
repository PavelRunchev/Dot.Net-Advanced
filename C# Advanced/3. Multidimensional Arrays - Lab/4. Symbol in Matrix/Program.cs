using System;
using System.Linq;
using System.Collections.Generic;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main()
        {
            int matrinxSizes = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrinxSizes, matrinxSizes];
            for (int i = 0; i < matrinxSizes; i++)
            {
                char[] inputRows = Console.ReadLine().ToCharArray();
                for (int g = 0; g < inputRows.Length; g++)
                {
                    matrix[i, g] = inputRows[g];
                }
            }

            string symbol = Console.ReadLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int g = 0; g < matrix.GetLength(1); g++)
                {
                    if(Char.Parse(symbol) == matrix[i, g])
                    {
                        Console.WriteLine($"({i}, {g})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
