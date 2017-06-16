using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intRanges
{
    public class intRange
    {
        int x; //левая граница
        int y; //правая граница
        int length;
        bool type; // отрезок/интервал 
        private bool isEmpty;

        public bool IsEmpty
        {
            get { return isEmpty; }
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public bool Type
        {
            get { return type; }
        }

        public int Lenght
        {
            get { return length; }
        }

        public intRange()
        {
            x = 0;
            y = 0;
            length = 0;
        }
        
        public intRange(int x, int y)
        {
            this.x = x;
            this.y = y;
            length = y - x + 1;
        }

        public intRange(int x, int y, bool type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
            if (type)
                if (x == y) length = 0;
                else length = y - x - 1;
            else length = y - x + 1;
        }

        public bool Contains(int number)
        {
            if (type) return number > this.x && number < this.y;
            return number >= this.x && number <= this.y;
        }

        public bool Intersect(intRange range)
        {
            if (range.X == x && range.Y == y) return true;
            if (type)
            {
                if (range.X > x && range.X < y) return true;
                if (range.Y > x && range.Y < y) return true;
                if (range.X < x && range.Y > y) return true;
            }
            else
            {
                if (range.X >= x && range.X <= y) return true;
                if (range.Y >= x && range.Y <= y) return true;
                if (range.X <= x && range.Y >= y) return true;
            }
            return false;
        }

        public static void Main()
        {

        }

    }
}
