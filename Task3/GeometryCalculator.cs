using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class GeometryCalculator
    {
        public static double Calculate(double length, double width)
        {
            return length * width;
        }

        public static double Calculate(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}
