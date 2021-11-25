using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            decimal areOf = (decimal)Math.PI * radius * radius;
            return (double)areOf;
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            decimal areOfRectangle = length * width;
            return (double)areOfRectangle;
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            decimal areaOfTriangle = ground * h / 2;
            return (double)areaOfTriangle;
        }
    }
}
