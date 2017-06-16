using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using intRanges;

namespace intRangeTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEmpty()
        {
            intRange test = new intRange();
            Assert.AreEqual(test.IsEmpty, false);
        }

        [TestMethod]
        public void NotIsEmpty()
        {
            intRange test = new intRange();
            Assert.AreEqual(!test.IsEmpty, true);
        }

        [TestMethod]
        public void LengthCorrect()
        {
            intRange test = new intRange(5, 5, true);
            Assert.AreEqual(test.Lenght, 0);
        }

        [TestMethod]
        public void LenghtStretch()
        {
            intRange test = new intRange(5, 10, true);
            Assert.AreEqual(test.Lenght, 4);
        }

        [TestMethod]
        public void LenghtInterval()
        {
            intRange test = new intRange(5, 10, false);
            Assert.AreEqual(test.Lenght, 6);
        }

        [TestMethod]
        public void ContainsCorrect()
        {
            intRange test = new intRange(5, 12);
            Assert.AreEqual(test.Contains(7),true);
        }

        [TestMethod]
        public void ContainsCorrectBorder()
        {
            intRange test = new intRange(5, 12);
            Assert.AreEqual(test.Contains(5), true);
        }

        [TestMethod]
        public void ContainsNotCorrect()
        {
            intRange test = new intRange(5, 12);
            Assert.AreEqual(test.Contains(3), false);
        }

        [TestMethod]
        public void ContainsIntervalCorrect()
        {
            intRange test = new intRange(5, 12,true);
            Assert.AreEqual(test.Contains(6), true);
        }

        [TestMethod]
        public void ContainsIntervalNotCorrect()
        {
            intRange test = new intRange(5, 12, true);
            Assert.AreEqual(test.Contains(3), false);
        }

        [TestMethod]
        public void ContainsIntervalBorder()
        {
            intRange test = new intRange(5, 12, true);
            Assert.AreEqual(test.Contains(5), false);
        }

        [TestMethod]
        public void IntersectStretch()
        {
            intRange testStretch1 = new intRange(0, 10);
            intRange testStretch2 = new intRange(5, 15);
            intRange testStretch3 = new intRange(15, 20);
            Assert.AreEqual(testStretch1.Intersect(testStretch2), true);
            Assert.AreEqual(testStretch1.Intersect(testStretch1), true);
            Assert.AreEqual(testStretch2.Intersect(testStretch1), true);
            Assert.AreEqual(testStretch2.Intersect(testStretch3), true);
        }

        [TestMethod]
        public void IntersectInterval()
        {
            intRange testInterval1 = new intRange(0, 10, true);
            intRange testInterval2 = new intRange(5, 15, true);
            intRange testInterval3 = new intRange(15, 20, true);
            Assert.AreEqual(testInterval1.Intersect(testInterval2),true);
            Assert.AreEqual(testInterval1.Intersect(testInterval1), true);
            Assert.AreEqual(testInterval2.Intersect(testInterval1), true);
            Assert.AreEqual(testInterval2.Intersect(testInterval3), false);
        }

        [TestMethod]
        public void IntersectIntervalStretch()
        {
            intRange testInterval1 = new intRange(0, 10, true);
            intRange testInterval2 = new intRange(15, 20, true);
            intRange testStretch = new intRange(3, 13, false);
            Assert.AreEqual(testInterval1.Intersect(testStretch), true);
            Assert.AreEqual(testStretch.Intersect(testInterval1), true);
            Assert.AreEqual(testStretch.Intersect(testInterval2), false);
            Assert.AreEqual(testInterval2.Intersect(testStretch), false);
        }

    }
}
