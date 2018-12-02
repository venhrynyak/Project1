using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Rectangle
    {
        Point[] points;
        int width, height;

        public Rectangle(Point[] points, int width, int height)
        {
            this.points = points;
            this.width = width;
            this.height = height;
        }

        public int Perimeter()
        {
            return 2 * (width + height);
        }





        public int Area()
        {
            return width * height;
        }





    }
}
