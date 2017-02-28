using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTTD
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class IntRange
    {
        public int Max { get; }
        public int Min { get; }
        public bool IsEmpty { get; }
        public int Length { get; }
        public bool Interval { get; }

        public IntRange(int a, int b,bool interval)
        {
            Interval = interval;

            if(Interval == false && a == b)
            {
                IsEmpty = true;
            }

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

        }

        public bool Contains(int number)
        {
            if(number>Min && number < Max)
            {
                return true;
            }

            if(Interval==false && (number==Max || number == Min))
            {
                return true;
            }
            return false;
        }

        public bool Intersect(IntRange range)
        {
            if(Max<=range.Min || Min >=range.Max)
            {
                if (Interval == false && range.Interval == false)
                {
                    return true;
                }
                return false;
            }
            return true;
        }

    }
}
