using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThemeUnitTesting.Library;

namespace ThemeUnitTesting
{
 
    [TestClass]
    public class Tests
    {
        private Triangle Instance;
        [TestMethod]
         public void Equilateral_Triangle_true()
        {
            Instance = new Triangle(2, 2, 2);
            Assert.AreEqual(true, Instance.EquilateralTriangle());
        }

        [TestMethod]
        public void Equilateral_Triangle_false()
        {
            Instance = new Triangle(3, 2, 2);
            Assert.AreEqual(false, Instance.EquilateralTriangle());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Exception_if_side_less_one()
        {
            Instance = new Triangle(0, 0, 1);
            Instance.SideLessNull();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Exception_if_side_less_null()
        {
            Instance = new Triangle(-1, -1, -1);
            Instance.SideLessNull();
        }
        [TestMethod]//равнобедренный
        public void Isosceles_Triangle_true()
        {
            Instance = new Triangle(4, 4, 2);
            Assert.AreEqual(true, Instance.IsoscelesTriangle());
        }
        [TestMethod]
        public void Isosceles_Triangle_false()
        {
            Instance = new Triangle(1, 2, 3);
            Assert.AreEqual(false, Instance.IsoscelesTriangle());
        }
        [TestMethod]//Прямоугольный 
        public void Rectangular_Triangle_true()
        {
            Instance = new Triangle(4, 3, 5);
            Assert.AreEqual(true, Instance.RectangularTriangle());
        }
        [TestMethod]
        public void Rectangular_Triangle_false()
        {
            Instance = new Triangle(1, 1, 1);
            Assert.AreEqual(false, Instance.RectangularTriangle());
        }
        [TestMethod]//Вырожденный
        public void Degenerate_Triangle_true()
        {
            Instance = new Triangle(1, 2, 10);
            Assert.AreEqual(true, Instance.DegenerateTriangle());
        }
        [TestMethod]
        public void Degenerate_Triangle_false()
        {
            Instance = new Triangle(2, 3, 4);
            Assert.AreEqual(false, Instance.DegenerateTriangle());
        }
        [TestMethod]
        public void NO_Triangle()
        {
            Instance = new Triangle(2,100,-2);
            Assert.AreEqual(true, Instance.NoTriangle());
        }

    }
}
