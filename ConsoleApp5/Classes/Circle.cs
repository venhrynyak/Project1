using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }



        public Circle(Point center, int radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public double Area()
        {
            return 2 * Math.PI * Radius;
        }






    }
}
