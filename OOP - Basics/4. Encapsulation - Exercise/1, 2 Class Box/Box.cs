using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get => length;
            set {
                if (value <= 0)
                {
                    Exception err = new ArgumentException("Length cannot be zero or negative.");
                    Console.WriteLine(err.Message);
                    Environment.Exit(0);
                }

                this.length = value;
            }
        }

        public double Width 
        {
            get => width;
            set {
                if(value <= 0)
                {
                    Exception err = new ArgumentException("Width cannot be zero or negative.");
                    Console.WriteLine(err.Message);
                    Environment.Exit(0);
                }

                this.width = value;
            }
        }

        public double Height
        {
            get => height;
            set {
                if (value <= 0)
                {
                    Exception err = new ArgumentException("Height cannot be zero or negative.");
                    Console.WriteLine(err.Message);
                    Environment.Exit(0);
                }

                this.height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double SurfaceArea()
        {
            return (this.length * this.height * 2) + (this.width * this.height * 2) + (this.length * this.width * 2);
        }
        
        public double LateralSurfaceArea()
        {
            return (this.length * this.height * 2) + (this.width * this.height * 2);
        }
        public double Volume()
        {
            return this.length * this.width * this.height;
        }
    }
}
