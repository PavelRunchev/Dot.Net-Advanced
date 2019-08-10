using System;
using System.Linq;
using System.Collections.Generic;

namespace FastFood
{
    class Program
    {
        static void Main()
        {
            int foodBox = int.Parse(Console.ReadLine());
            int[] inputFoods = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> foods = new Queue<int>(inputFoods);

            Console.WriteLine(foods.Max());
            while(foods.Count > 0)
            {
                if(foods.Peek() > foodBox) break;
              
                foodBox -= foods.Dequeue();                
            }

            Console.WriteLine(foods.Count == 0 ?
                "Orders complete" 
                : $"Orders left: {String.Join(" ", foods.ToArray())}");           
        }
    }
}
