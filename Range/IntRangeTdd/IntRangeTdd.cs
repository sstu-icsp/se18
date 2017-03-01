using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntRangeTddProject
{
    public class IntRangeTdd
    {
        int leftBorder;
        int rightBorder;
        bool isEmpty;
        int length;
        bool isInterval;

        public int LeftBorder
        {
            get { return leftBorder; }
        }

        public int RightBorder
        {
            get { return rightBorder; }
        }

        public bool IsEmpty
        {
            get { return isEmpty; }
        }

        public int Length
        {
            get{ return length; }
        }

        public bool IsInterval
        {
            get { return isInterval; }
        }

        public IntRangeTdd()
        {
            leftBorder = 0;
            rightBorder = 0;
            isEmpty = true;
            length = 0;
            isInterval = false;
        }

        public IntRangeTdd(int leftBorder, int rightBorder)
        {
            this.leftBorder = leftBorder;
            this.rightBorder = rightBorder;
            length = rightBorder - leftBorder + 1;
            isInterval = false;
        }

        public IntRangeTdd(int leftBorder, int rightBorder, bool isInterval)
        {
            this.leftBorder = leftBorder;
            this.rightBorder = rightBorder;
            this.isInterval = isInterval;
            if (isInterval)
                if (leftBorder == rightBorder) length = 0;
                else length = rightBorder - leftBorder - 1;
            else length = rightBorder - leftBorder + 1;
            
        }

        public bool Contains(int number)
        {
            if(isInterval) return number > this.leftBorder && number < this.rightBorder;
            return number >= this.leftBorder && number <= this.rightBorder;
        }

        public bool Intersect(IntRangeTdd range)
        {
            if (range == this || (range.LeftBorder == leftBorder && range.RightBorder == rightBorder)) return true;
            if (isInterval)
            {
                if (range.LeftBorder > leftBorder && range.LeftBorder < rightBorder) return true;
                if (range.RightBorder > leftBorder && range.RightBorder < rightBorder) return true;
                if (range.LeftBorder < leftBorder && range.RightBorder > rightBorder) return true;
            }
            else
            {
                if (range.LeftBorder >= leftBorder && range.LeftBorder <= rightBorder) return true;
                if (range.RightBorder >= leftBorder && range.RightBorder <= rightBorder) return true;
                if (range.LeftBorder <= leftBorder && range.RightBorder >= rightBorder) return true;
            }
            return false;
        }
    }
}
