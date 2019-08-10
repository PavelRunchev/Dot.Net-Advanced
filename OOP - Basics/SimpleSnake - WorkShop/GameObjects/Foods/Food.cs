using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SimpleSnake.GameObjects.Foods
{
    public abstract class Food : Point
    {       
        private char foodSymbol;
        private Random random;

        protected Food(char foodSymbol, int points)
        {
            this.random = new Random();
            this.foodSymbol = foodSymbol;
            this.FoodPoints = points;
        }

        public int FoodPoints { get; private set; }

        public void SetRandomPosition(Queue<Point> snakeElements)
        {
            this.LeftX = random.Next(2, Console.WindowWidth - 2);
            this.TopY = random.Next(2, Console.WindowHeight - 2);

            bool isPointOfSnake = snakeElements.Any(x => x.LeftX == this.LeftX && x.TopY == this.TopY);

            while (isPointOfSnake)
            {
                this.LeftX = random.Next(2, Console.WindowWidth - 2);
                this.TopY = random.Next(2, Console.WindowHeight - 2);

                isPointOfSnake = snakeElements.Any(x => x.LeftX == this.LeftX && x.TopY == this.TopY);
            }

            Console.BackgroundColor = ConsoleColor.Blue;
            this.Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;
        }

        public bool IsFoodPoint(Point snake)
        {
            return snake.TopY == this.TopY && snake.LeftX == this.LeftX;
        }
    }
}
