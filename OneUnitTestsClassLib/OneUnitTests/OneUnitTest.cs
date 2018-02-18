using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneUnitTestsClassLib;

namespace OneUnitTests
{
    [TestClass]
    public class OneUnitTest
    {
        private OneUnit Instance;

        [TestInitialize]
        public void TesInit()
        {
            Instance = new OneUnit();
        }

        [TestMethod]
        public void getOnThreePoint()
        {
            double result = Instance.triangleArea(new Point(), new Point(), new Point());
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void nullPOint()
        {
              Instance.triangleArea(null, null, null);
        }

        [TestMethod]
        public void rightTriangle()
        {
            double result = Instance.triangleArea(new Point(0,0), new Point(5, 0), new Point(0, 5));
            Assert.AreEqual(12.5, result);
        }
        [TestMethod]
        public void equilateralTriangle()
        {
            double result = Instance.triangleArea(new Point(0, 0), new Point(4, 0), new Point(2, 4));
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void isoscelesTriangle()
        {
            double result = Instance.triangleArea(new Point(1, 1), new Point(-2, 4), new Point(-2, -2));
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void randomTriangle()
        {
            double result = Instance.triangleArea(new Point(-1, -3), new Point(1, 2), new Point(-2, 0));
            Assert.AreEqual(5.5, result);
        }
        [TestMethod]
        public void areaOnThreeSide()
        {
            double result = Instance.triangleArea(3, 4, 5);
            Assert.AreEqual(6, result);
        }
    }
}
