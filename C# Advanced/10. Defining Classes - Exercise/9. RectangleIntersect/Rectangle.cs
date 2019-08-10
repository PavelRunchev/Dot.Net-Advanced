using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleIntersect
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double x;
        private double y;

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public bool Intersect(Rectangle secondRectangle)
        {
            double left = this.X + this.width;
            double bottom = this.Y + this.Height;

            if(left < secondRectangle.X || secondRectangle.X + secondRectangle.Width < this.X
                || bottom < secondRectangle.Y || this.Y > secondRectangle.Y + secondRectangle.Height)
                return false;

            return true;
        }

        public Rectangle(string id, double width, double height, double x, double y)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
        }
    }
}
