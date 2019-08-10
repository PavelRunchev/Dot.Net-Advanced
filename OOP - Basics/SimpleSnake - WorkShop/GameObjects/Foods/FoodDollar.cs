using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
    public class FoodDollar : Food
    {
        private const char foodSymbol = '$';
        private const int points = 2;

        public FoodDollar()
            : base(foodSymbol, points)
        { }
    }
}
