using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class StartUp
    {
        static void Main()
        {
            int[] dimestion = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimestion[0];
            int cols = dimestion[1];
            Board board = new Board(rows, cols);
            board.CreateMatrix();
           
            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] playerCordinates = command
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int[] evilCordinates = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                Player evil = new Player(evilCordinates[0], evilCordinates[1]);
                while (evil.Row >= 0 && evil.Col >= 0)
                {
                    if (board.IsInsideInMatrix(evil.Row, evil.Col))
                        board.Matrix[evil.Row, evil.Col] = 0;

                    evil.Row--;
                    evil.Col--;
                }

                Player player = new Player(playerCordinates[0], playerCordinates[1]);
                while (player.Row >= 0 && player.Col < board.Matrix.GetLength(1))
                {
                    if (board.IsInsideInMatrix(player.Row, player.Col))
                        sum += board.Matrix[player.Row, player.Col];

                    player.Col++;
                    player.Row--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}
