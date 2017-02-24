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
        int Ugol1_2, Ugol2_3, Ugol3_4, Ugol4_1;
        static void Main(string[] args)
        {
        }

        public RectangleTdd(int s1, int s2, int s3, int s4, int u12, int u23, int u34, int u41)
        {
            if (s1 < 0 || s2 < 0 || s3 < 0 || s4 < 0) throw new ArgumentException("Недопустимое значение стороны");
            if (u12 < 0 || u23 < 0 || u34 < 0 || u41 < 0 || u12 > 360 || u23 > 360 || u34 > 360 || u41 > 360) throw new ArgumentException("Недопустимое значение угла");
            Side_one = s1; Side_Two = s2; Side_Three = s3; Side_Four = s4;
            Ugol1_2 = u12; Ugol2_3 = u23;Ugol3_4 = u34;Ugol4_1 = u41;
        }

        public Boolean isPramougolnik()
        {
            if (Ugol1_2 == 90 && Ugol2_3 == 90 && Ugol3_4 == 90 && Ugol4_1 == 90)
                if (Side_one==Side_Three && Side_Two==Side_Four)
                return true;
            return false;
        }

        public Boolean isUnknown()
        {
            if (!isPramougolnik())
                return true;
            return false;
        }

        public Boolean isSquare()
        {
            if (Side_one==Side_Two && Side_Two==Side_Three && Side_Three==Side_Four)
                if (Ugol1_2 == 90)
                return true;
            return false;
        }

        public Boolean isRomb()
        {
            if (Side_one == Side_Two && Side_Two == Side_Three && Side_Three == Side_Four)
                return true;
            return false;
        }

        public Boolean isParallelogram()
        {
            if (Side_one == Side_Three && Side_Two == Side_Four)
                if (Ugol1_2==Ugol3_4 && Ugol2_3==Ugol4_1)
                return true;
            return false;
        }
    }
}
