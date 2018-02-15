using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneUnitClassLib;

namespace OneUnitTests
{
    [TestClass]
    public class OneUnitTests
    {
        private OneUnit Instance;

        [TestInitialize]
        public void TesInit()
        {
            Instance = new OneUnit();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void nullFirstArg()
        {
            Instance.triangleArea(null, new Point(1, 2), new Point(2, 3));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void nullSecondtArg()
        {
            Instance.triangleArea(new Point(1, 2), null, new Point(2, 3));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void nullThirdArg()
        {
            Instance.triangleArea(new Point(1, 2), new Point(2, 3), null);
        }

        [TestMethod]
        public void isoscelesTriangle()//равносторонний
        {
            double result = Instance.triangleArea(new Point(1, 1), new Point(-2, 4), new Point(-2, -2));
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void equilateralTriangle()//равнобедренный
        {
            double result = Instance.triangleArea(new Point(0, 0), new Point(4, 0), new Point(2, 4));
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void rightTriangle()//прямоугольный
        {
            double result = Instance.triangleArea(new Point(-1, -1), new Point(4, -1), new Point(-1, 4));
            Assert.AreEqual(12.5, result);
        }

        [TestMethod]
        public void randomTriangle()//рандомный
        {
            double result = Instance.triangleArea(new Point(-1, -3), new Point(1, 2), new Point(-2, 0));
            Assert.AreEqual(5.5, result);
        }

    }
}
