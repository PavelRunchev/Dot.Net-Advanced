using System;

namespace PascalTriangle
{
    class PascalTriangle
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            long[][] jaggedArray = new long[count][];
            
            //Initiacling all rows and set all indexes with default value "1".
            for (int i = 0; i < count; i++)
            {
                jaggedArray[i] = new long[i + 1];
                for (int g = 0; g <= i; g++)
                    jaggedArray[i][g] = 1;
            }
            
            for (int row = 2; row < jaggedArray.Length; row++)
            {
                for (int col = 1; col < jaggedArray[row].Length - 1; col++)
                    jaggedArray[row][col] = jaggedArray[row - 1][col] + jaggedArray[row - 1][col - 1];
            }

            PrintTrianglePascal(jaggedArray);
        }

        private static void PrintTrianglePascal(long[][] triangle)
        {
            foreach (long[] row in triangle)
                Console.WriteLine(String.Join(" ", row));
        }
    }
}
