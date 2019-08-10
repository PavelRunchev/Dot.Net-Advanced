using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius
        {
            get => radius;
            set => radius = value;
        }

        public void Draw()
        {
            double radiusIn = this.radius - 0.4;
            double radiusOut = this.radius + 0.4;
            for (double i = this.Radius; i >= -this.Radius; i--)
            {
                for (double g = -this.Radius; g < radiusOut; g += 0.5)
                {
                    double value = g * g + i * i;
                    if(value >= radiusIn * radiusIn && value <= radiusOut * radiusOut)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
