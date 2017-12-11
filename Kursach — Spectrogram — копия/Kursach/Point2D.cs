using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point2D()
        {
            X = 0;
            Y = 0;
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
