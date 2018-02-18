using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneUnitTestsClassLib;

namespace OneUnitTestsClassLib
{
    public class OneUnit
    {
        public double triangleArea(Point firstP, Point secondP, Point thirdP)
        {
            if (firstP != null || secondP != null || thirdP != null)
            {
                double area = 0;
                area = 0.5 * ((firstP.x - thirdP.x) * (secondP.y - thirdP.y)
                    - (secondP.x - thirdP.x) * (firstP.y - thirdP.y));
                return area;
            }
            else throw new ArgumentException();
        }

        public double triangleArea(double a, double b, double c)
        {
            double area = 0;
            double hP = (a + b + c) / 2;
            area = Math.Sqrt(hP * (hP - a) * (hP - b) * (hP - c));
            return area;
        }
    }
}
