using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rect
{
    public class Rectangle
    {
        int Side_One;
        int Side_Two;
        int Side_Three;
        int Side_Four;

        int Corner_One_And_Two;
        int Corner_Two_And_Three;
        int Corner_Three_And_Four;
        int Corner_Four_And_One;

        static void Main(string[] args)
        {
        }

        public Rectangle(int Side_One, int Side_Two, int Side_Three, int Side_Four, int Corner_One_And_Two, int Corner_Two_And_Three, int Corner_Three_And_Four, int Corner_Four_And_One)
        {
             if (Side_One < 0 || Side_Two < 0 || Side_Three < 0 || Side_Four < 0) throw new ArgumentException("Ошибка! Сторона меньше нуля!");

             this.Side_One = Side_One;
             this.Side_Two = Side_Two;
             this.Side_Three = Side_Three;
             this.Side_Four = Side_Four;

             if (Corner_One_And_Two < 0 || Corner_Two_And_Three < 0 || Corner_Three_And_Four < 0 || Corner_Four_And_One < 0 || Corner_One_And_Two > 360 || Corner_Two_And_Three > 360 || Corner_Three_And_Four > 360 || Corner_Four_And_One > 360)
                throw new ArgumentException("Ошибка! Недопустимое значение угла! (Допустимое от 0 до 360)");
             this.Corner_One_And_Two = Corner_One_And_Two;
             this.Corner_Two_And_Three = Corner_Two_And_Three;
             this.Corner_Three_And_Four = Corner_Three_And_Four;
             this.Corner_Four_And_One = Corner_Four_And_One;
            
        }

        public Boolean isRectangle()
        {
            if (Corner_One_And_Two == 90 && Corner_Two_And_Three == 90 && Corner_Three_And_Four == 90 && Corner_Four_And_One == 90)
            {
                return true;
            }
            else return false;
        }

        public Boolean isSingular() //Вырожденный
        {
            if (Corner_One_And_Two == 0 && Corner_Two_And_Three == 0 && Corner_Three_And_Four == 0 && Corner_Four_And_One == 0 ||
                Corner_One_And_Two == 180 && Corner_Two_And_Three == 180 && Corner_Three_And_Four == 180 && Corner_Four_And_One == 180 ||
                Corner_One_And_Two == 360 && Corner_Two_And_Three == 360 && Corner_Three_And_Four == 360 && Corner_Four_And_One == 360)
                return true;
            else return false;
        }

        public Boolean isUnknown()
        {
            if (!isRectangle() && !isSingular()) return true;
            else return false;
        }

        public Boolean isSquare()
        {
            
            if (Side_One == Side_Two && Side_One == Side_Three && Side_One == Side_Four && Corner_One_And_Two == 90 && Corner_Two_And_Three == 90 && Corner_Three_And_Four == 90 && Corner_Four_And_One == 90)
                return true;
            else return false;
        }

        public Boolean isRhombus()
        {
            if (Side_One == Side_Two && Side_Three == Side_Four || Side_One == Side_Four && Side_Two == Side_Three 
                && Corner_One_And_Two == Corner_Three_And_Four && Corner_Two_And_Three == Corner_Four_And_One)
                return true;
            else return false;
        }

        public Boolean isParallelogram()
        {
            if (Side_One == Side_Three && Side_Two == Side_Four) return true;
            else return false;
        }

    }
}
