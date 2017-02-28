using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class IntRange
    {
        public bool IsEmpty { get;}
        public int Length { get;}
        public int Max { get; }
        public int Min { get; }
        private bool Interval { get; }

        public IntRange(int a, int b, bool interval)
        {
            if (a == b) IsEmpty = true;

            if (a > b)
            {
                Max = a;
                Min = b;
            }
            else
            {
                Max = b;
                Min = a;
            }
            Length = Max - Min;
            Interval = interval;

        }


        public bool Contains(int number)
        {
            if (Interval == false && (number > Max || number < Min))
                return false;
            if (Interval == true && (number >= Max || number <= Min))
                return false;

            return true;
        }

        public bool Intersects(IntRange range)
        {
            if (Interval == false && (Max < range.Min || range.Max < Min))
                return false;
            if (Interval == true && (Max <= range.Min || range.Max <= Min))
                return false;
            return true;
        }
    }

}
