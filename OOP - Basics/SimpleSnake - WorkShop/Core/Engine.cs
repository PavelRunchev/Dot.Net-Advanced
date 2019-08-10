using SimpleSnake.GameObjects;
using SimpleSnake.Enums;
using System;
using System.Threading;

namespace SimpleSnake.Core
{
    public class Engine
    {
        private Point[] pointsDirection;
        private Direction direction;
        private Snake snake;
        private double sleepTime;

        public Engine(Snake snake)
        {
            this.pointsDirection = new Point[4];
            this.direction = Direction.Right;
            this.snake = snake;
            this.sleepTime = 100;
        }

        public void Run()
        {
            this.CreateDirections();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    this.GetNextDirection();
                }

                bool isMoving = this.snake.IsMoving(this.pointsDirection[(int)this.direction]);

                if (!isMoving)
                {
                    this.AskUserForRestart();
                }

                this.sleepTime -= 0.01;

                Thread.Sleep((int)this.sleepTime);
            }
            
        }   
        
        private void CreateDirections()
        {
            this.pointsDirection[0] = new Point(1, 0);
            this.pointsDirection[1] = new Point(-1, 0);
            this.pointsDirection[2] = new Point(0, 1);
            this.pointsDirection[3] = new Point(0, -1);
        }

        private void GetNextDirection()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();

            if(userInput.Key == ConsoleKey.LeftArrow && this.direction != Direction.Right)
            {
                this.direction = Direction.Left;
            }
            else if(userInput.Key == ConsoleKey.RightArrow && this.direction != Direction.Left)
            {
                this.direction = Direction.Right;
            }
            else if(userInput.Key == ConsoleKey.UpArrow)
            {
                if(this.direction != Direction.Down)
                {
                    this.direction = Direction.Up;
                }
            }
            else if(userInput.Key == ConsoleKey.DownArrow)
            {
                if(this.direction != Direction.Up)
                {
                    this.direction = Direction.Down;
                }
            }

            Console.CursorVisible = false;
        }

        private void AskUserForRestart()
        {
            int leftX = Console.WindowWidth / 2;
            int topY = Console.WindowHeight / 2;

            Console.SetCursorPosition(leftX, topY);
            Console.Write("Would you like to continue? Y/N");

            string input = Console.ReadLine();

            if(input == "y")
            {
                Console.Clear();
                StartUp.Main();
            }
            else
            {
                this.StopGame();
            }
        }

        private void StopGame()
        {
            Console.SetCursorPosition(20, 10);
            Console.Write("Game over!");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
