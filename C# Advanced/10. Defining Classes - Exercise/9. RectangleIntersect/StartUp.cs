using System;
using System.Linq;
using System.Collections.Generic;

namespace RectangleIntersect
{
    class StartUp
    {
        static void Main()
        {
            List<Rectangle> rectangles = new List<Rectangle>();
            int[] lines = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < lines[0]; i++)
            {
                string[] inputReactangle = Console.ReadLine().Split(" ").ToArray();
                string id = inputReactangle[0];
                double width = double.Parse(inputReactangle[1]);
                double height = double.Parse(inputReactangle[2]);
                double x = double.Parse(inputReactangle[3]);
                double y = double.Parse(inputReactangle[4]);
                Rectangle rectangle = new Rectangle(id, width, height, x, y);
                rectangles.Add(rectangle);
            }

            for (int i = 0; i < lines[1]; i++)
            {
                string[] inputId = Console.ReadLine().Split(" ").ToArray();
                string firstId = inputId[0];
                string secondId = inputId[1];
             
                Rectangle firstRectangle = rectangles.FirstOrDefault(r => r.Id == firstId);
                Rectangle secondRectangle = rectangles.FirstOrDefault(r => r.Id == secondId);
                //Print true or false!!!
                Console.WriteLine(firstRectangle.Intersect(secondRectangle) ? "true" : "false" );
            }
        }
    }
}
