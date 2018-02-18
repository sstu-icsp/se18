using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneUnitClassLib
{
    public class OneUnit
    {
        public double triangleArea(Point one, Point two, Point three)
        {
            if (one == null || two == null || three == null) throw new ArgumentException();
            double area = 0;
            area = 0.5 * ((one.x - three.x) * (two.y - three.y) - (two.x - three.x) * (one.y - three.y));
            return area;
        }
        public double triangleArea(double a, double b, double c)
        {
            double area = 0;
            double hP = (a + b + c) / 2;//halfPerimetre
            area = Math.Sqrt(hP*(hP - a)*(hP - b)*(hP - c));
            return area;
        }
    }
}
