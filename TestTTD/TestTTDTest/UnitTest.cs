using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTTD;

namespace TestTTDTest
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void IsEmptyIntervalFalse()
        {
            Assert.AreEqual(false, new IntRange(1, 1,true).IsEmpty);
        }

        [TestMethod]
        public void IsEmptyCutTrue()
        {
            Assert.AreEqual(true, new IntRange(1, 1, false).IsEmpty);
        }

        [TestMethod]
        public void Length()
        {
            Assert.AreEqual(2, new IntRange(3, 1, false).Length);
        }

        [TestMethod]
        public void LengthZer0()
        {
            Assert.AreEqual(0, new IntRange(1, 1, false).Length);
        }

        [TestMethod]
        public void ContainsCutFalse()
        {
            Assert.AreEqual(false, new IntRange(1, 3, false).Contains(4));
        }

        [TestMethod]
        public void ContainsCutTrue()
        {
            Assert.AreEqual(true, new IntRange(1, 3, false).Contains(2));
        }

        [TestMethod]
        public void ContainsIntervalFalse()
        {
            Assert.AreEqual(false, new IntRange(1, 3, true).Contains(4));
        }

        [TestMethod]
        public void ContainsIntervalTrue()
        {
            Assert.AreEqual(true, new IntRange(1, 3, true).Contains(2));
        }

        [TestMethod]
        public void ContainsCutEndTrue()
        {
            Assert.AreEqual(true, new IntRange(1, 3, false).Contains(1));
        }

        [TestMethod]
        public void ContainsIntervalEndFalse()
        {
            Assert.AreEqual(false, new IntRange(1, 3, true).Contains(1));
        }

        [TestMethod]
        public void IntersectIntervalTrue()
        {
            Assert.AreEqual(true, new IntRange(1, 3, true).Intersect(new IntRange(2, 4, true)));
        }

        [TestMethod]
        public void IntersectIntervalFalse()
        {
            Assert.AreEqual(false, new IntRange(1, 3, true).Intersect(new IntRange(4, 6, true)));
        }

        [TestMethod]
        public void IntersectCutTrue()
        {
            Assert.AreEqual(true, new IntRange(1, 3, false).Intersect(new IntRange(2, 4, true)));
        }

        [TestMethod]
        public void IntersectCutFalse()
        {
            Assert.AreEqual(false, new IntRange(1, 3, false).Intersect(new IntRange(4, 6, true)));
        }

        [TestMethod]
        public void IntersectIntervalEndFalse()
        {
            Assert.AreEqual(false, new IntRange(1, 3, true).Intersect(new IntRange(3, 6, true)));
        }

        [TestMethod]
        public void IntersectCutEndTrue()
        {
            Assert.AreEqual(true, new IntRange(1, 3, false).Intersect(new IntRange(3, 6, false)));
        }

        [TestMethod]
        public void IntersectInterval_CutEndFalse()
        {
            Assert.AreEqual(false, new IntRange(1, 3, false).Intersect(new IntRange(3, 6, true)));
        }

        [TestMethod]
        public void ContainsNegativeIntervalTrue()
        {
            Assert.AreEqual(true, new IntRange(-5, -8, true).Contains(-6));
        }

        [TestMethod]
        public void ContainsNegativeCutTrue()
        {
            Assert.AreEqual(true, new IntRange(-5, -8, false).Contains(-6));
        }

        [TestMethod]
        public void IntersectNegativeIntervalTrue()
        {
            Assert.AreEqual(true, new IntRange(-5, -8, true).Intersect(new IntRange(-4,-10,true)));
        }

        [TestMethod]
        public void IntersectNegativeCutTrue()
        {
            Assert.AreEqual(true, new IntRange(-5, -8, false).Intersect(new IntRange(-4, -10, false)));
        }
    }
}
