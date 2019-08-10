using System;
using System.Linq;

namespace Jagged_ArrayModification
{
    class JaggedArrayModification
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[][] matrix = new int[matrixSize][];

            for (int i = 0; i < matrixSize; i++)
            {
                int[] inputRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[i] = new int[inputRow.Length];
                for (int g = 0; g < inputRow.Length; g++)
                    matrix[i][g] = inputRow[g];
            }

            string inputCommands;
            while ((inputCommands = Console.ReadLine()) != "END")
            {
                string[] arguments = inputCommands.Split();
                if(arguments.Length == 4)
                {
                    string command = arguments[0];
                    int row = int.Parse(arguments[1]);
                    int col = int.Parse(arguments[2]);
                    int value = int.Parse(arguments[3]);

                    if ((row < 0 || row > matrix.Length - 1)
                           || (col < 0 || col > matrix[row].Length - 1))
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }

                    if (command == "Add")                      
                            matrix[row][col] += value;                  
                    else if(command == "Subtract")                       
                            matrix[row][col] -= value;                      
                }               
            }

            for (int row = 0; row < matrix.Length; row++)
                Console.WriteLine(String.Join(" ", matrix[row]));
        }     
    }
}
