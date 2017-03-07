using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectTdd;

namespace RectTddTest
{
    [TestClass]
    public class RectangleTddTest
    {
        RectangleTdd instance;
        [TestMethod]
        public void isRectangle()
        {
            instance = new RectangleTdd(1,2,1,2,90,90,90,90);
            Assert.IsTrue(instance.isRectangle());
        }

        [TestMethod]
        public void CheckFigureIsUnknown()
        {
            instance = new RectangleTdd(2, 2, 1, 2, 75, 90, 105, 90);
            Assert.IsTrue(instance.isUnknown());
        }

        [TestMethod]
        public void CheckFigureIsSquare()
        {
            instance = new RectangleTdd(2, 2, 2, 2, 90, 90, 90, 90);
            Assert.IsTrue(instance.isSquare());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Недопустимое значение стороны фигуры!")]
        public void CheckCorrectSideException()
        {
            instance = new RectangleTdd(-2, 1, 2, 1, 60, 120, 60, 120);
        }

        [TestMethod]
        public void CheckFigureisRhombus()
        {
            instance = new RectangleTdd(2, 2, 2, 2, 120, 60, 120, 60);
            Assert.IsTrue(instance.isRhombus());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Недопустимое значение угла фигуры!")]
        public void CheckCorrectCornerException()
        {
            instance = new RectangleTdd(2, 1, 2, 1, -60, 360, 60, 120);
        }

        [TestMethod]
        public void CheckFigureIsParallelogram()
        {
            instance = new RectangleTdd(2, 1, 2, 1, 120, 60, 120, 60);
            Assert.IsTrue(instance.isParallelogram());
        }
    }
}
