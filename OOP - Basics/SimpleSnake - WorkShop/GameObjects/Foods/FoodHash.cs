﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
    public class FoodHash : Food
    {
        private const char foodSymbol = '#';
        private const int points = 3;

        public FoodHash()
            : base(foodSymbol, points)
        { }
    }
}
