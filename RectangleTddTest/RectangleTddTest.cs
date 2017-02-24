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
        public void CheckFigureIsPramougolnik()
        {
            instance = new RectangleTdd(1,2,1,2,90,90,90,90);
            Assert.IsTrue(instance.isPramougolnik());
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
        public void CheckFigureIsRomb()
        {
            instance = new RectangleTdd(2, 2, 2, 2, 120, 60, 120, 60);
            Assert.IsTrue(instance.isRomb());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Недопустимое значение угла фигуры!")]
        public void CheckCorrectUgolException()
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
