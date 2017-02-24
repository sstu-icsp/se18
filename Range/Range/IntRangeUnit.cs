using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    public class IntRangeUnit
    {
        private int x;
        private int y;
        private bool isEmpty;
        private int length;
        private bool isInterval;

        public int X
        {
            get { return this.x; }
        }
        public int Y
        {
            get { return this.y; }
        }
        public bool IsEmpty
        {
            get { return this.isEmpty; }
        }
        public int Length
        {
            get { return this.length; }
        }
        public bool IsInterval
        {
            get { return this.isInterval; }
        }
        public IntRangeUnit()
        {
            x = 0;
            y = 0;
            length = 0;
            isEmpty = true;
            isInterval = false;
        }
        public IntRangeUnit(int x,int y)
        {
            if (x > y) throw new ArgumentException("Величина левой границы должна быть меньше правой");
            this.x = x;
            this.y = y;
            length = y - x + 1;
            isInterval = false;
            isEmpty = false;
        }
        public IntRangeUnit(int x, int y,bool isInterval)
        {
            if (x > y) throw new ArgumentException("Величина левой границы должна быть меньше правой");
            this.x = x;
            this.y = y;
            isEmpty = false;
            if (isInterval)
            {
                this.isInterval = true;
                if (x == y) length = 0;
                else length = y - x - 1;
            }
            else
            {
                this.isInterval = false;
                length = y - x + 1;
            }
            
        }
        public bool Contains(int number)
        {
            if (IsEmpty||Length==0) return false;
            if (IsInterval)
                return (number > X && number < Y);
            else
                return (number >= X && number <= Y);
        }

        public bool Intersects(IntRangeUnit range)
        {
            if (this.isEmpty || range.isEmpty) return false;
            if ((this.IsInterval && range.IsInterval) & (range.X == this.X && range.Y == this.Y)) return true;
            if (this.IsInterval) return (Contains(range.X) || Contains(range.Y));
            if(range.IsInterval) return (range.Contains(this.X)||range.Contains(this.Y));
            return Contains(range.X)|| Contains(range.Y)|| range.Contains(this.X) || range.Contains(this.Y);
        }
    }
}
