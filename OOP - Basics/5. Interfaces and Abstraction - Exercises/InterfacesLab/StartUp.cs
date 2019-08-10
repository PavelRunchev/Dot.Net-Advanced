using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main()
        {
            //circle radius input!
            int radius = int.Parse(Console.ReadLine());

            //rectangle parameters input!
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            //Create Instance to classes!
            IDrawable circle = new Circle(radius);
            IDrawable rectangle = new Rectangle(width, height);
            circle.Draw();
            rectangle.Draw();
        }
    }
}
