using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntRangeTddProject
{
    [TestClass]
    public class IntRangeTddTests
    {
        [TestMethod]
        public void CorrectIsEmpty()
        {
            IntRangeTdd test = new IntRangeTdd();
            Assert.IsTrue(test.IsEmpty,"Промежуток должен являться пустым");
        }

        [TestMethod]
        public void CorrectLength()
        {
            IntRangeTdd test = new IntRangeTdd(0,10);
            Assert.AreEqual(11, test.Length, "Ожидается длина промежутка, равная 10");
        }

        [TestMethod]
        public void CorrectContains()
        {
            IntRangeTdd test = new IntRangeTdd(0, 10);
            Assert.IsTrue(test.Contains(5), "Число 5 должно входить в промежуток [0;10]");
        }


        [TestMethod]
        public void IncorrectContains()
        {
            IntRangeTdd test = new IntRangeTdd(0, 10);
            Assert.IsFalse(test.Contains(11),"Число 11 не должно входить в промежуток [0;10]");
        }

        [TestMethod]
        public void CorrectIntersectsSelf()
        {
            IntRangeTdd test = new IntRangeTdd(0, 10);
            Assert.IsTrue(test.Intersect(test),"Должно возвращаться true при пересечении промежутка с собой");
        }

        [TestMethod]
        public void CorrectIntersectsAtLeftBorder()
        {
            IntRangeTdd test = new IntRangeTdd(0, 10);
            IntRangeTdd testIntersectAtLeftBorder = new IntRangeTdd(-10, 0);
            Assert.IsTrue(test.Intersect(testIntersectAtLeftBorder), "Должно возвращаться true при пересечении промежутков на границе");
        }

        [TestMethod]
        public void CorrectIntersectLeftSide()
        {
            IntRangeTdd test = new IntRangeTdd(0, 10);
            IntRangeTdd testLeftSide = new IntRangeTdd(-5, 5);
            Assert.IsTrue(test.Intersect(testLeftSide), "Должно возвращаться true при пересечении промежутков [0;10] [-5;5]");
        }

        [TestMethod]
        public void CorrectIntersectRightSide()
        {
            IntRangeTdd test = new IntRangeTdd(0, 10);
            IntRangeTdd testRightSide = new IntRangeTdd(5, 15);
            Assert.IsTrue(test.Intersect(testRightSide), "Должно возвращаться true при пересечении промежутков [0;10] [5;15]");
        }

        [TestMethod]
        public void CorrectIntersectArRightBorder()
        {
            IntRangeTdd test = new IntRangeTdd(0, 10);
            IntRangeTdd testIntersectAtRightBorder = new IntRangeTdd(10, 20);
            Assert.IsTrue(test.Intersect(testIntersectAtRightBorder), "Должно возвращаться true при пересечении промежутков на границе");
        }

        [TestMethod]
        public void CorrectInsideIntersect()
        {
            IntRangeTdd test = new IntRangeTdd(0, 10);
            IntRangeTdd bigInterval = new IntRangeTdd(-10, 20);
            Assert.IsTrue(test.Intersect(bigInterval), "Должно возвращаться true при нахождении тестируемого промежутка внутри большего промежутка");
        }

        [TestMethod]
        public void CorrectOutsideIntersect()
        {
            IntRangeTdd test = new IntRangeTdd(0, 10);
            IntRangeTdd smallInterval = new IntRangeTdd(2, 8);
            Assert.IsTrue(test.Intersect(smallInterval), "Должно возвращаться true при нахождении малого промежутка внуутри тестируемого промежутка ");
        }

        [TestMethod]
        public void CorrectNonIntersect()
        {
            IntRangeTdd test = new IntRangeTdd(0, 10);
            IntRangeTdd NonIntersectingInterval = new IntRangeTdd(20,30);
            Assert.IsFalse(test.Intersect(NonIntersectingInterval), "Должно возвращаться false при явно отсутствии пересечения");
        }

        [TestMethod]
        public void CorrectIntervalLength()
        {
            IntRangeTdd testInterval = new IntRangeTdd(0, 10,true);
            Assert.AreEqual(9, testInterval.Length,"Длина интервала не должна учитывать числа на границах");
        }

        [TestMethod]
        public void PoingLength()
        {
            IntRangeTdd testPoint = new IntRangeTdd(0, 0);
            Assert.AreEqual(1, testPoint.Length, "Длина точки должна быть 1");
        }

        [TestMethod]
        public void CorrectPointIntervalLength()
        {
            IntRangeTdd testIntervalPoint = new IntRangeTdd(0, 0, true);
            Assert.AreEqual(0, testIntervalPoint.Length, "Длина интервала-точки должна быть нулевой");
        }

        [TestMethod]
        public void CorrectContainsInterval()
        {
            IntRangeTdd testInterval= new IntRangeTdd(0, 10, true);
            Assert.IsTrue(testInterval.Contains(5), "Должно возвращаться true при явном нахождении точки в интервале");
        }

        [TestMethod]
        public void CorrectNonContainsInterval()
        {
            IntRangeTdd testInterval = new IntRangeTdd(0, 10, true);
            Assert.IsFalse(testInterval.Contains(20), "Должно возвращаться false при явном отсутствии точки в интервале");
        }

        [TestMethod]
        public void CorrectNonContainsAtBoardInterval()
        {
            IntRangeTdd testInterval = new IntRangeTdd(0, 10, true);
            Assert.IsFalse(testInterval.Contains(0), "Должно возвращаться false, когда точка лежит на границе интервала");
        }


        [TestMethod]
        public void CorrectIntersectIntervalIntervalAtBoard()
        {
            IntRangeTdd testInterval = new IntRangeTdd(0, 10,true);
            IntRangeTdd testIntervalAtLeftBoard = new IntRangeTdd(-10, 0, true);
            IntRangeTdd testIntervalAtRightBoard = new IntRangeTdd(10, 20, true);
            Assert.IsFalse(testInterval.Intersect(testIntervalAtLeftBoard),"Интервалы не должны пересекаться на границе");
            Assert.IsFalse(testInterval.Intersect(testIntervalAtRightBoard), "Интервалы не должны пересекаться на границе");
        }

        [TestMethod]
        public void CorrectIntersectIntervalInterval()
        {
            IntRangeTdd testInterval = new IntRangeTdd(0, 10, true);
            IntRangeTdd testBiggerInterval = new IntRangeTdd(-10, 20, true);
            IntRangeTdd testSmallerInterval = new IntRangeTdd(2, 8, true);
            Assert.IsTrue(testInterval.Intersect(testBiggerInterval), "Должно возвращаться true при пересечении большего и меньшего интервалов");
            Assert.IsTrue(testInterval.Intersect(testSmallerInterval), "Должно возвращаться true при пересечении большего и меньшего интервалов");
        }

        [TestMethod]
        public void CorrectIntersectIntervalSegment()
        {
            IntRangeTdd testInterval = new IntRangeTdd(0, 10, true);
            IntRangeTdd testBiggerSegment = new IntRangeTdd(-10, 20);
            IntRangeTdd testSmallerSegment = new IntRangeTdd(2, 8);
            Assert.IsTrue(testInterval.Intersect(testBiggerSegment), "Должно возвращаться true при пересечении большего отрезка и меньшего интервала");
            Assert.IsTrue(testInterval.Intersect(testSmallerSegment), "Должно возвращаться true при пересечении большего интервала и меньшего отрезка");
        }

    }
}
