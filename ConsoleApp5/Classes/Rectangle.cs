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
        public Rectangle(Point[] points)
        {
            this.points = points;
        }


        public int Area()
        {
            return width * height;
        }





    }
}
