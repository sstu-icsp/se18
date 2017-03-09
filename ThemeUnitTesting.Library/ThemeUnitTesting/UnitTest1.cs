using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using ThemeUnitTesting.Library;

namespace ThemeUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        private Triangle Instance;
        [TestInitialize]
        public void TestInitialize()
        {
            Instance = new Triangle();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Я с нулём.")]
        public void TestMethod0_0()
        {
            int res = Triangle.Pover(0, 3, 4);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Я с -5.")]
        public void TestMethod0_1()
        {
            int res = Triangle.Pover(-5, 3, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Я с -1.")]
        public void TestMethod0_2()
        {
            int res = Triangle.Pover(3, -1, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Я с -4.")]
        public void TestMethod0_3()
        {
            int res = Triangle.Pover(10, 3, -4);
        }
        [TestMethod]
        public void TestMethod_Type2_0()
        {
            int res = Triangle.Pover(3, 3, 4);

            Assert.AreEqual(2, res, "Я должен быть равнобедренный");
        }

        [TestMethod]
        public void TestMethod_Type2_1()
        {
            int res = Triangle.Pover(3, 10, 10);

            Assert.AreEqual(2, res, "Я должен быть равнобедренный");
        }

        [TestMethod]
        public void TestMethod_Type2_2()
        {
            int res = Triangle.Pover(14, 3, 14);

            Assert.AreEqual(2, res, "Я должен быть равнобедренный");
        }

        [TestMethod]
        public void TestMethod_Type3_0()
        {
            int res = Triangle.Pover(3, 3, 3);

            Assert.AreEqual(3, res, "Я должен быть равнобедренный");
        }
        [TestMethod]
        public void TestMethod_Type3_1()
        {
            int res = Triangle.Pover(13, 13, 13);

            Assert.AreEqual(3, res, "Я должен быть равнобедренный");
        }

        [TestMethod]
        public void TestMethod_Type4_0()
        {
            int res = Triangle.Pover(5, 4, 3);

            Assert.AreEqual(4, res, "Я должен быть равнобедренный");
        }

        
    }



    [TestClass]
    public class UnitTDDTest1
    {
        private TriangleTDD Instance;
        [TestInitialize]
        public void TestInitialize()
        {
            Instance = new TriangleTDD();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Я с ннулями.")]
        public void TestTDDMethod0_0()
        {
            int res = TriangleTDD.PvTDD(0, 0, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Я с -6.")]
        public void TestTDDMethod0_1()
        {
            int res = TriangleTDD.PvTDD(1, -6, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Я с -1.")]
        public void TestTDDMethod0_2()
        {
            int res = TriangleTDD.PvTDD(-1, -1, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Я с -10.")]
        public void TestTDDMethod0_3()
        {
            int res = TriangleTDD.PvTDD(10, 3, -10);
        }


        [TestMethod]
        public void TestTDDMetod_Type1_0()
        {
            int res =  TriangleTDD.PvTDD( 6, 7, 8);
            Assert.AreEqual(1, res, "Я есть");
        }
        [TestMethod]
        public void TestTDDMetod_Type1_1()
        {
            int res = TriangleTDD.PvTDD(7,5,6);
            Assert.AreEqual(1, res, "Я есть");
        }
        [TestMethod]
        public void TestTDDMetod_Type1_2()
        {
            int res = TriangleTDD.PvTDD(7, 8, 6);
            Assert.AreEqual(1, res, "Я есть");
        }

        [TestMethod]
        public void TestTDDMetod_Type0_0()
        {
            int res = TriangleTDD.PvTDD(17, 8, 6);
            Assert.AreEqual(0, res, "Я НЕ существую");
        }

        [TestMethod]
        public void TestTDDMetod_Type0_1()
        {
            int res = TriangleTDD.PvTDD(1, 8, 6);
            Assert.AreEqual(0, res, "Я НЕ существую");
        }

        [TestMethod]
        public void TestTDDMetod_Type0_2()
        {
            int res = TriangleTDD.PvTDD(8, 8, 26);
            Assert.AreEqual(0, res, "Я НЕ существую");
        }

        [TestMethod]
        public void TestTDDMethod_Type2_0()
        {
            int res = TriangleTDD.PvTDD(3, 3, 4);

            Assert.AreEqual(2, res, "Я должен быть равнобедренный");
        }

        [TestMethod]
        public void TestTDDMethod_Type2_1()
        {
            int res = TriangleTDD.PvTDD(3, 10, 10);

            Assert.AreEqual(2, res, "Я должен быть равнобедренный");
        }

        [TestMethod]
        public void TestTDDMethod_Type2_2()
        {
            int res = TriangleTDD.PvTDD(14, 3, 14);

            Assert.AreEqual(2, res, "Я должен быть равнобедренный");
        }

        [TestMethod]
        public void TestTDDMethod_Type3_0()
        {
            int res = TriangleTDD.PvTDD(3, 3, 3);

            Assert.AreEqual(3, res, "Я должен быть равнобедренный");
        }
        [TestMethod]
        public void TestTDDMethod_Type3_1()
        {
            int res = TriangleTDD.PvTDD(13, 13, 13);

            Assert.AreEqual(3, res, "Я должен быть равнобедренный");
        }

        [TestMethod]
        public void TestTDDMethod_Type4_0()
        {
            int res = TriangleTDD.PvTDD(5, 4, 3);

            Assert.AreEqual(4, res, "Я должен быть равнобедренный");
        }


    }
}
