using System;
using System.Linq;

namespace MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main()
        {
            int[] inputMatrixSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int inputRowSize = inputMatrixSizes[0];
            int inputColSize = inputMatrixSizes[1];
            string[,] matrix = new string[inputRowSize, inputColSize];

            //fill matrix with Elements from input!
            matrix = FillMatrixWithElements(matrix);

            string commands;
            while ((commands = Console.ReadLine()) != "END")
            {
                string[] inputCommand = commands.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string command = inputCommand[0];
                if(command == "swap" && inputCommand.Length == 5)
                    //Sawp elements from matrix if valid!!!
                    SwapElementsInMatrix(matrix, inputCommand);                 
                else
                    Console.WriteLine("Invalid input!");
            }

            //End Program!!!
        }

        private static string[,] FillMatrixWithElements(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] inputRow = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);            
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            return matrix;
        }

        private static void SwapElementsInMatrix(string[,] matrix, string[] inputCommand)
        {
            int firstRow = int.Parse(inputCommand[1]);
            int firstCol = int.Parse(inputCommand[2]);
            int secondRow = int.Parse(inputCommand[3]);
            int secondCol = int.Parse(inputCommand[4]);

            if ((firstRow < 0 || firstRow > matrix.GetLength(0) - 1)
                || (firstCol < 0 || firstCol > matrix.GetLength(1) - 1)
                || (secondRow < 0 || secondRow > matrix.GetLength(0) - 1)
                || (secondCol < 0 || secondCol > matrix.GetLength(1) - 1))
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            //get valid elements!
            string firstElement = matrix[firstRow, firstCol];
            string secondElement = matrix[secondRow, secondCol];
            //Swap elements.
            matrix[firstRow, firstCol] = secondElement;
            matrix[secondRow, secondCol] = firstElement;

            //Print Matrix with new swap elements and continue next commands!
            Print(matrix);
        }

        private static void Print(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
