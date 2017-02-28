using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace TestTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEmpty_Interval()
        {
            Assert.AreEqual(true, new IntRange(1, 1, true).IsEmpty);
        }

        [TestMethod]
        public void IsEmpty_Otrezok()
        {
            Assert.AreEqual(true, new IntRange(1, 1, false).IsEmpty);
        }

        [TestMethod]
        public void Length()
        {
            Assert.AreEqual(2, new IntRange(3, 1, false).Length);
        }

        [TestMethod]
        public void Contains_Max_Left_Interval_InMiddle_True()
        {
            Assert.AreEqual(true, new IntRange(6, 1, true).Contains(4));
        }

        [TestMethod]
        public void Contains_Max_Left_Interval_InMiddle_False()
        {
            Assert.AreEqual(false, new IntRange(6, 1, true).Contains(7));
        }

        [TestMethod]
        public void Contains_Max_Right_Interval_InMiddle_True()
        {
            Assert.AreEqual(true, new IntRange(1, 6, true).Contains(4));
        }

        [TestMethod]
        public void Contains_Max_Right_Interval_InMiddle_False()
        {
            Assert.AreEqual(false, new IntRange(1, 6, true).Contains(7));
        }

        [TestMethod]
        public void Contains_Max_Left_Interval_Edge_False()
        {
            Assert.AreEqual(false, new IntRange(6, 1, true).Contains(6));
        }

        [TestMethod]
        public void Contains_Max_Right_Interval_Edge_False()
        {
            Assert.AreEqual(false, new IntRange(1, 6, true).Contains(1));
        }

        [TestMethod]
        public void Contains_Max_Left_Otrezok_InMiddle_True()
        {
            Assert.AreEqual(true, new IntRange(6, 1, false).Contains(4));
        }

        [TestMethod]
        public void Contains_Max_Left_Otrezok_InMiddle_False()
        {
            Assert.AreEqual(false, new IntRange(6, 1, false).Contains(7));
        }

        [TestMethod]
        public void Contains_Max_Right_Otrezok_InMiddle_True()
        {
            Assert.AreEqual(true, new IntRange(1, 6, false).Contains(4));
        }

        [TestMethod]
        public void Contains_Max_Right_Otrezok_InMiddle_False()
        {
            Assert.AreEqual(false, new IntRange(1, 6, false).Contains(7));
        }

        [TestMethod]
        public void Contains_Max_Left_Otrezok_Edge_True()
        {
            Assert.AreEqual(true, new IntRange(6, 1, false).Contains(6));
        }

        [TestMethod]
        public void Contains_Max_Right_Otrezok_Edge_True()
        {
            Assert.AreEqual(true, new IntRange(1, 6, false).Contains(1));
        }

        [TestMethod]
        public void Intersect_Left_Interval_True()
        {
            Assert.AreEqual(true, new IntRange(1, 6, true).Intersects(new IntRange(4,7,true)));
        }

        [TestMethod]
        public void Intersect_Right_Interval_True()
        {
            Assert.AreEqual(true, new IntRange(4, 7, true).Intersects(new IntRange(1, 6, true)));
        }

        [TestMethod]
        public void Intersect_Left_Interval_False()
        {
            Assert.AreEqual(false, new IntRange(1, 6, true).Intersects(new IntRange(9, 10, true)));
        }

        [TestMethod]
        public void Intersect_Right_Interval_False()
        {
            Assert.AreEqual(false, new IntRange(9, 10, true).Intersects(new IntRange(1, 6, true)));
        }

        [TestMethod]
        public void Intersect_Right_Interval_Edge_False()
        {
            Assert.AreEqual(false, new IntRange(9, 10, true).Intersects(new IntRange(7, 9, true)));
        }

        [TestMethod]
        public void Intersect_Left_Interval_Edge_False()
        {
            Assert.AreEqual(false, new IntRange(7, 9, true).Intersects(new IntRange(9, 10, true)));
        }

        [TestMethod]
        public void Intersect_Right_Otrezok_Edge_True()
        {
            Assert.AreEqual(true, new IntRange(9, 10, false).Intersects(new IntRange(7, 9, false)));
        }

        [TestMethod]
        public void Intersect_Left_Otrezok_Edge_True()
        {
            Assert.AreEqual(true, new IntRange(7, 9, false).Intersects(new IntRange(9, 10, false)));
        }
    }
}
