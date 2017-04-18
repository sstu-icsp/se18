using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountSalary.Tests
{
    [TestClass]
    public class SalaryTest
    {
     
      [TestMethod]
      public void Correct_Salary()
      {
            Salary sal = new Salary();
            Assert.AreEqual(10000, sal.CalculateSalary(10000, 1, 1));
      }

       [TestMethod]
       [ExpectedException(typeof(ArgumentException), "Must be exception for level is more than 6")]
       public void Level_More_6_Exception()
       {
            Salary sal = new Salary();
            sal.CalculateSalary(10000, 1, 7);
       }

       [TestMethod]
       [ExpectedException(typeof(ArgumentException), "Must be exception for Base Salary is less than 0")]
       public void BaseSalary_Less_Zero_Exception()
       {
            Salary sal = new Salary();
            sal.CalculateSalary(-1, 1, 5);

       }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for Base Coeff is less than 0")]
        public void BaseCoeff_Less_Zero_Exception()
        {
            Salary sal = new Salary();
            sal.CalculateSalary(10000, -1, 5);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for level is less than 0")]
        public void Level_Less_Zero_Exception()
        {
            Salary sal = new Salary();
            sal.CalculateSalary(10000, 1, -1);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for Base Salary is equal to 0")]
        public void BaseSalary_Equal_Zero_Exception()
        {
            Salary sal = new Salary();
            sal.CalculateSalary(0, 1, 5);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for Base Coeff is equal to 0")]
        public void BaseCoeff_Equal_Zero_Exception()
        {
            Salary sal = new Salary();
            sal.CalculateSalary(10000, 0, 5);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for level is equal to 0")]
        public void Level_Equal_Zero_Exception()
        {
            Salary sal = new Salary();
            sal.CalculateSalary(10000, 1, 0);

        }

        [TestMethod]
        public void Correct_Salary_In_Second_Condition()
        {
            Salary sal = new Salary();
            Assert.AreEqual(120000,sal.CalculateSalary(10000,2,3));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for Base Salary more than formula")]
        public void BaseSalary_More_Formula_Exception()
        {
            Salary sal = new Salary();
            sal.CalculateSalary(200000, 1, 3);
        }


    }
}
