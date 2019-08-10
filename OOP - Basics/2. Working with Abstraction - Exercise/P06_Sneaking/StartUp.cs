using System;

namespace P06_Sneaking
{
    class StartUp
    {
        static void Main()
        {
            int roomRows = int.Parse(Console.ReadLine());
            Room room = new Room(roomRows);

            for (int row = 0; row < roomRows; row++)
            {
                char[] coordinate = Console.ReadLine().ToCharArray();
                room.InitializeMatrix(row, coordinate);
            }

            var moves = Console.ReadLine().ToCharArray();

            int[] samPosition = new int[2];
            foreach (char move in moves)
            {
                room.MoveEnemies();               
                room.CheckForEnemy();
                if (room.FinishProcess) break;
                room.MoveSam(move);
                room.CheckForNikoladze();
                if (room.FinishProcess) break;
            }

            Console.WriteLine(room.ToString());         
        }
    }
}
