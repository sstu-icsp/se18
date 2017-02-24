using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Range;
namespace IntRangeUnitTests
{
    [TestClass]
    public class IntRangeUnitTests
    {
        [TestMethod]
        public void CreateEmpty()
        {
            IntRangeUnit testEmpty = new IntRangeUnit();
            Assert.IsTrue(testEmpty.IsEmpty, "При создании экземпляра без аргументов промежуток должен считаться пустым");
        }

        [TestMethod]
        public void CreateInterval()
        {
            IntRangeUnit testInterval = new IntRangeUnit(10,15,true);
            Assert.IsTrue(testInterval.IsInterval,"При указании в качестве true третьего аргумента в конструкторе, должен создаваться Интервал");
        }

        [TestMethod]
        public void CreateSegment()
        {
            IntRangeUnit testSegment1 = new IntRangeUnit(10, 15, false);
            IntRangeUnit testSegment2 = new IntRangeUnit(10, 15);
            Assert.IsFalse(testSegment1.IsInterval, "При указании в качестве false третьего аргумента в конструкторе, должен создаваться Отрезок");
            Assert.IsFalse(testSegment2.IsInterval, "При отсутствии третьего аргумента в конструкторе, должен создаваться Отрезок");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "При неправильном порядке левого и правого концов интервала бросается исключение")]
        public void IllegalIntervalArgument()
        {
            IntRangeUnit testException = new IntRangeUnit(15,10,true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "При неправильном порядке левого и правого концов отрезка бросается исключение")]
        public void IllegalSegmentArgument()
        {
            IntRangeUnit testException = new IntRangeUnit(15, 10);
        }

        [TestMethod]
        public void CorrectIntervalLength()
        {
            IntRangeUnit testInterval = new IntRangeUnit(0,10,true);
            Assert.AreEqual(9, testInterval.Length);
        }

        [TestMethod]
        public void CorrectSegmentLength()
        {
            IntRangeUnit testSegment = new IntRangeUnit(0, 10);
            Assert.AreEqual(11, testSegment.Length);
        }

        [TestMethod]
        public void CorrectEmptyLength()
        {
            IntRangeUnit testSegment = new IntRangeUnit();
            Assert.AreEqual(0, testSegment.Length);
        }

        [TestMethod]
        public void ContaintsInInterval()
        {
            IntRangeUnit testInterval=new IntRangeUnit(-10,10,true);
            Assert.IsTrue(testInterval.Contains(5),"В интервал должны входить числа, которые явно там присутствуют");
            Assert.IsFalse(testInterval.Contains(11),"В интервал не должны входить числа, которые находятся за его пределами");
            Assert.IsFalse(testInterval.Contains(10),"В интервал не должны входить числа на его концах");
        }

        [TestMethod]
        public void ContaintsInSegment()
        {
            IntRangeUnit testInterval = new IntRangeUnit(-10, 10);
            Assert.IsTrue(testInterval.Contains(5), "В отрезок должны входить числа, которые явно там присутствуют");
            Assert.IsFalse(testInterval.Contains(11), "В отрезок не должны входить числа, которые находятся за его пределами");
            Assert.IsTrue(testInterval.Contains(10), "В отрезок должны входить числа на его концах");
        }

        [TestMethod]
        public void ContaintsInEmpty()
        {
            IntRangeUnit testEmpty = new IntRangeUnit();
            Assert.IsFalse(testEmpty.Contains(5), "В пустой промежуток ничего не может входить");
            Assert.IsFalse(testEmpty.Contains(11), "В пустой промежуток ничего не может входить");
            Assert.IsFalse(testEmpty.Contains(10), "В пустой промежуток ничего не может входить");
        }

        [TestMethod]
        public void IntersectSegmentSegment()
        {
            IntRangeUnit testSegment1 = new IntRangeUnit(0, 10);
            IntRangeUnit testSegment2 = new IntRangeUnit(5, 15);
            IntRangeUnit testSegment3 = new IntRangeUnit(15, 20);
            Assert.IsTrue(testSegment1.Intersects(testSegment2),"Должно возвращаться true при явном пересечении отрезков");
            Assert.IsTrue(testSegment1.Intersects(testSegment1), "Должно возвращаться true при пересечении отрезка с самим собой");
            Assert.IsTrue(testSegment2.Intersects(testSegment1), "Должно возвращаться true при явном пересечении отрезков");
            Assert.IsTrue(testSegment2.Intersects(testSegment3), "Должно возвращаться true при пересечении отрезков на их концах");
        }

        [TestMethod]
        public void IntersectIntervalInterval()
        {
            IntRangeUnit testInterval1 = new IntRangeUnit(0, 10,true);
            IntRangeUnit testInterval2 = new IntRangeUnit(5, 15, true);
            IntRangeUnit testInterval3 = new IntRangeUnit(15, 20, true);
            Assert.IsTrue(testInterval1.Intersects(testInterval2), "Должно возвращаться true при явном пересечении интервалов");
            Assert.IsTrue(testInterval1.Intersects(testInterval1), "Должно возвращаться true при пересечении интервала с самим собой");
            Assert.IsTrue(testInterval2.Intersects(testInterval1), "Должно возвращаться true при явном пересечении интервалов");
            Assert.IsFalse(testInterval2.Intersects(testInterval3), "Должно возвращаться false при пересечении интервалов на их концах");
        }

        [TestMethod]
        public void IntersectIntervalSegment()
        {
            IntRangeUnit testInterval1 = new IntRangeUnit(0, 10, true);
            IntRangeUnit testSegment = new IntRangeUnit(5, 15, false);
            IntRangeUnit testInterval2 = new IntRangeUnit(15, 20, true);
            Assert.IsTrue(testInterval1.Intersects(testSegment), "Должно возвращаться true при явном пересечении промежутков");
            Assert.IsTrue(testSegment.Intersects(testInterval1), "Должно возвращаться true при явном пересечении промежутков");
            Assert.IsFalse(testSegment.Intersects(testInterval2), "Должно возвращаться false при пересечении интервала и отрезка на их концах");
            Assert.IsFalse(testInterval2.Intersects(testSegment), "Должно возвращаться false при пересечении интервала и отрезка на их концах");
        }

        [TestMethod]
        public void IntersectEmpty()
        {
            IntRangeUnit testInterval = new IntRangeUnit(0, 10, true);
            IntRangeUnit testSegment = new IntRangeUnit(0, 10, false);
            IntRangeUnit testEmpty = new IntRangeUnit();
            Assert.IsFalse(testInterval.Intersects(testEmpty), "Должно возвращаться false при пересечении с пустым промежутком");
            Assert.IsFalse(testSegment.Intersects(testEmpty), "Должно возвращаться false при пересечении с пустым промежутком");
        }
    }
}
