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

        int ugol_One_And_Two;
        int ugol_Two_And_Three;
        int ugol_Three_And_Four;
        int ugol_Four_And_One;

        static void Main(string[] args)
        {
        }

        public Rectangle(int Side_One, int Side_Two, int Side_Three, int Side_Four, int ugol_One_And_Two, int ugol_Two_And_Three, int ugol_Three_And_Four, int ugol_Four_And_One)
        {
            //try
            //{
                if (Side_One < 0 || Side_Two < 0 || Side_Three < 0 || Side_Four < 0) throw new ArgumentException("Ошибка! Сторона меньше нуля!");

                this.Side_One = Side_One;
                this.Side_Two = Side_Two;
                this.Side_Three = Side_Three;
                this.Side_Four = Side_Four;

                if (ugol_One_And_Two < 0 || ugol_Two_And_Three < 0 || ugol_Three_And_Four < 0 || ugol_Four_And_One < 0 || ugol_One_And_Two > 360 || ugol_Two_And_Three > 360 || ugol_Three_And_Four > 360 || ugol_Four_And_One > 360)
                    throw new ArgumentException("Ошибка! Недопустимое значение угла! (Допустимое от 0 до 360)");
                this.ugol_One_And_Two = ugol_One_And_Two;
                this.ugol_Two_And_Three = ugol_Two_And_Three;
                this.ugol_Three_And_Four = ugol_Three_And_Four;
                this.ugol_Four_And_One = ugol_Four_And_One;
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //}

        }

        public Boolean isPramougRect()
        {
            if (ugol_One_And_Two == 90 && ugol_Two_And_Three == 90 && ugol_Three_And_Four == 90 && ugol_Four_And_One == 90)
            {
                return true;
            }
            else return false;
        }

        public Boolean isVyrojdenyy()
        {
            return false;
        }

        public Boolean isUnknown()
        {
            if (!isPramougRect() && !isVyrojdenyy()) return true;
            else return false;
        }

        public Boolean isSquare()
        {
            
            if (Side_One == Side_Two && Side_One == Side_Three && Side_One == Side_Four && ugol_One_And_Two == 90 && ugol_Two_And_Three == 90 && ugol_Three_And_Four == 90 && ugol_Four_And_One == 90)
                return true;
            else return false;
        }

        public Boolean isRomb()
        {
            if (Side_One == Side_Two && Side_Three == Side_Four || Side_One == Side_Four && Side_Two == Side_Three 
                && ugol_One_And_Two == ugol_Three_And_Four && ugol_Two_And_Three == ugol_Four_And_One)
                return true;
            else return false;
        }

        public Boolean isParallelogram ()
        {
            if (Side_One == Side_Three && Side_Two == Side_Four) return true;
            else return false;
        }

    }
}
