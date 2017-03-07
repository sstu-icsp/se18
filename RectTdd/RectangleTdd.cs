using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectTdd
{
    public class RectangleTdd
    {
        int Side_one, Side_Two, Side_Three, Side_Four;
        int Corner1_2, Corner2_3, Corner3_4, Corner4_1;
        static void Main(string[] args)
        {
        }

        public RectangleTdd(int s1, int s2, int s3, int s4, int u12, int u23, int u34, int u41)
        {
            if (s1 < 0 || s2 < 0 || s3 < 0 || s4 < 0) throw new ArgumentException("Недопустимое значение стороны");
            if (u12 < 0 || u23 < 0 || u34 < 0 || u41 < 0 || u12 > 360 || u23 > 360 || u34 > 360 || u41 > 360) throw new ArgumentException("Недопустимое значение угла");
            Side_one = s1; Side_Two = s2; Side_Three = s3; Side_Four = s4;
            Corner1_2 = u12; Corner2_3 = u23;Corner3_4 = u34;Corner4_1 = u41;
        }

        public Boolean isRectangle()
        {
            if (Corner1_2 == 90 && Corner2_3 == 90 && Corner3_4 == 90 && Corner4_1 == 90)
                if (Side_one==Side_Three && Side_Two==Side_Four)
                return true;
            return false;
        }

        public Boolean isSingular() //Вырожденный
        {
            if (Corner1_2 == 0 && Corner2_3 == 0 && Corner3_4 == 0 && Corner4_1 == 0 ||
                Corner1_2 == 180 && Corner2_3 == 180 && Corner3_4 == 180 && Corner4_1 == 180 ||
                Corner1_2 == 360 && Corner2_3 == 360 && Corner3_4 == 360 && Corner4_1 == 360)
                return true;
            else return false;
        }

        public Boolean isUnknown()
        {
            if (!isRectangle() && !isSingular())
                return true;
            return false;
        }

        public Boolean isSquare()
        {
            if (Side_one==Side_Two && Side_Two==Side_Three && Side_Three==Side_Four)
                if (Corner1_2 == 90)
                return true;
            return false;
        }

        public Boolean isRhombus()
        {
            if (Side_one == Side_Two && Side_Two == Side_Three && Side_Three == Side_Four)
                return true;
            return false;
        }

        public Boolean isParallelogram()
        {
            if (Side_one == Side_Three && Side_Two == Side_Four)
                if (Corner1_2==Corner3_4 && Corner2_3==Corner4_1)
                return true;
            return false;
        }
    }
}
