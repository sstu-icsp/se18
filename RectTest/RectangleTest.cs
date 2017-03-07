using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rect;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RectTest
{
    [TestClass]
    public class RectangleTest
    {
        private Rectangle Instance;

        [ClassInitialize]
        public static void ClassInitialize(TestContext tc)
        {
            Console.WriteLine("Тестирую тесты!");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Instance = new Rectangle(2, 1, 2, 1, 90, 90, 90, 90);
        }

        [TestMethod]
        public void correctIsPramoug()
        {
            Instance = new Rectangle(2, 1, 2, 1, 90, 90, 90, 90);
            Boolean result = Instance.isRectangle();
            Assert.AreEqual(true, result, "Прямоугольный, когда все углы равны 90 градусов");
        }

        [TestMethod]
        public void correctIsUnknown()
        {
            Instance = new Rectangle(2, 1, 2, 1, 110, 60, 120, 70);
            Boolean result = Instance.isUnknown();
            Assert.AreEqual(true, result, "Никакой, произвольный");
        }

        [TestMethod]
        public void correctIsSquare()
        {
            Instance = new Rectangle(1, 1, 1, 1, 90, 90, 90, 90);
            Boolean result = Instance.isSquare();
            Assert.AreEqual(true, result, "Квадрат, когда все стороны равны и углы равны 90 градусов");
        }

        [TestMethod]
        public void correctIsRomb()
        {
            Instance = new Rectangle(2, 2, 1, 1, 60, 120, 60, 120);
            Boolean result = Instance.isRhombus();
            Assert.AreEqual(true, result, "Ромб, когда сторона противоположные углы равны и примыкающие к этим углам сторны равны");
        }

        [TestMethod]
        public void correctIsParallelogram()
        {
            Instance = new Rectangle(2, 1, 2, 1, 60, 120, 60, 120);
            Boolean result = Instance.isParallelogram();
            Assert.AreEqual(true, result, "Параллелограм, когда противоположные стороны равны");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Ошибка! Недопустимое значение угла! (Допустимое от 0 до 360)")]
        public void correctUgolException()
        {
            Instance = new Rectangle(2, 1, 2, 1, -60, 120, 380, 120);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Ошибка! Сторона меньше нуля!")]
        public void correctStoronaException()
        {
            Instance = new Rectangle(-2, 1, 2, 1, 60, 120, 60, 120);
        }
    }
}
