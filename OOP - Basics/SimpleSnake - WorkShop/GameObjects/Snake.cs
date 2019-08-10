using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SimpleSnake.GameObjects.Foods;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private const char snakeSymbol = '\u25CF';
        private int foodIndex;

        private Queue<Point> snakeElements;
        private Food[] foods;
        private Obstacle obstacle;

        private int nextLeftX;
        private int nextTopY;

        public Snake()
        {
            this.snakeElements = new Queue<Point>();
            this.foods = new Food[3];
            this.foodIndex = this.RandomFoodNumber();
            this.obstacle = new Obstacle();
            this.GetFoods();
            this.CreateSnake();
        }

        public void CreateSnake()
        {
            for (int topY = 1; topY <= 6; topY++)
            {
                this.snakeElements.Enqueue(new Point(2, topY));
            }

            this.foods[this.foodIndex].SetRandomPosition(this.snakeElements);
        }

       public bool IsMoving(Point direction)
        {
            Point currentSnakeHead = this.snakeElements.Last();
            this.GetNextPoint(direction, currentSnakeHead);
            bool isPointOfSnake = this.snakeElements.Any(x => x.LeftX == nextLeftX && x.TopY == nextTopY);

            if (isPointOfSnake)
                return false;

            Point snakeNewHead = new Point(this.nextLeftX, this.nextTopY);
            

            if (snakeNewHead.LeftX == -1)
            {
                snakeNewHead.LeftX = Console.WindowWidth - 1;
            }
            else if(snakeNewHead.LeftX == Console.WindowWidth)
            {
                snakeNewHead.LeftX = 0;
            }

            if(snakeNewHead.TopY == -1)
            {
                snakeNewHead.TopY = Console.WindowHeight - 1;
            }
            else if(snakeNewHead.TopY == Console.WindowHeight)
            {
                snakeNewHead.TopY = 0;
            }

            if(DateTime.Now.Second % 5 == 0)
            {
                this.obstacle.SetRandomObstacle(snakeElements, direction);
            }

            if (this.obstacle.IsObstacle(snakeNewHead))
            {
                return false;
            }

            this.snakeElements.Enqueue(snakeNewHead);
            Console.BackgroundColor = ConsoleColor.Green;
            snakeNewHead.Draw(snakeSymbol);
          
            Console.BackgroundColor = ConsoleColor.White;

            if (this.foods[this.foodIndex].IsFoodPoint(snakeNewHead))
            {
                this.Eat(direction, currentSnakeHead);
            }

            Point snakeTail = this.snakeElements.Dequeue();
            snakeTail.Draw(' ');
            

            return true;
        }

        private void Eat(Point direction, Point currentSnakeHead)
        {
            int length = this.foods[foodIndex].FoodPoints;

            for (int i = 0; i < length; i++)
            {
                this.snakeElements.Enqueue(new Point(this.nextLeftX, this.nextTopY));
                this.GetNextPoint(direction, currentSnakeHead);
            }

            this.foodIndex = this.RandomFoodNumber();
            this.foods[foodIndex].SetRandomPosition(this.snakeElements);
        }

        private int RandomFoodNumber()
        {
            return new Random().Next(0, this.foods.Length);
        }

        private void GetFoods()
        {
            this.foods[0] = new FoodHash();
            this.foods[1] = new FoodDollar();
            this.foods[2] = new FoodAsterisk();
        }

        private void GetNextPoint(Point direction, Point snakeHead)
        {
            this.nextLeftX = snakeHead.LeftX + direction.LeftX;
            this.nextTopY = snakeHead.TopY + direction.TopY;
        }
    }
}
