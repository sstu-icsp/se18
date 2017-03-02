using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeUnitTesting.Library
{
    public class Triangle
    {
        private int ab { get; }
        private int bc { get; }
        private int ca { get; }

        public Triangle(int a, int b, int c)
        {
            this.ab = a;
            this.bc = b;
            this.ca = c;
        }

        public Boolean EquilateralTriangle()
        {
            return (ab == bc && bc == ca && ca == ab);
        }
        public Boolean IsoscelesTriangle()
        {
            return (ab == bc || bc == ca || ca == ab);
        }
        public Boolean RectangularTriangle()
        {
            return ((ab ^ 2 + bc ^ 2) == (ca ^ 2) || (bc ^ 2 + ca ^ 2) == (ab ^ 2) || (ab ^ 2 + ca ^ 2) == (bc ^ 2));
        }
        public Boolean DegenerateTriangle()
        {
            return (ab + bc < ca || bc + ca < ab || ab + ca < bc);
        }

        public void SideLessNull()
        {
            if (ab <= 0 || bc <= 0 || ca <= 0)
            throw new ArgumentException("Сторона не может быть меньше или равна 0");
        }
        public Boolean NoTriangle()
        {
            return (RectangularTriangle() || EquilateralTriangle() || IsoscelesTriangle()||ab<=0||bc<=0||ca<=0);

        }

    }
}