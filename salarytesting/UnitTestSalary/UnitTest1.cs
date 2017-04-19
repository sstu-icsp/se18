using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using salarytesting;

namespace UnitTestSalary
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Ошибка! Уровень не может быть больше 6!")]
        public void correctLevelException()
        {
            Salary salary = new Salary(100, 2, 7);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Ошибка! Параметры расчета не могут быть меньше 0")]
        public void correctParameterException()
        {
            Salary salary1 = new Salary(-1, 2, 2);
            Salary salary2 = new Salary(100, -2, 2);
            Salary salary3 = new Salary(100, 2, -2);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Ошибка!Базовая зарплата не должна превышать значение, рассчитываемое по формуле 50.000 * Уровень!")]
        public void correctBase_SalaryException()
        {
            Salary salary = new Salary(500000, 2, 1);
        }

        [TestMethod]
        public void SalaryCalculatorLevelFrom2To5()
        {
            Salary salary = new Salary(100, 2, 3);
            Assert.AreEqual(1200, salary.SalaryCalculator());
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void FailedSalaryCalculatorLevelFrom2To5()
        {
            Salary salary = new Salary(100, 2, 3);
            Assert.AreEqual(1000, salary.SalaryCalculator());
        }
        [TestMethod]
        public void SalaryCalculatorLevelTo2OrFrom5()
        {
            Salary salary = new Salary(100, 2, 1);
            int sal = (int)salary.SalaryCalculator();
            Assert.AreEqual(200, sal);
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void FailedSalaryCalculatorLevelTo2OrFrom5()
        {
            Salary salary = new Salary(100, 2, 1);
            Assert.AreEqual(250, salary.SalaryCalculator());
        }
    }
}
