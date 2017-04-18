using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountSalary.Tests
{
    [TestClass]
    public class SalaryTest
    {
     
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for Level is more than six.")]
        public void Level_Bigger_Than_Six()
        {
            Salary sal = new Salary();
            int salary = sal.CalculateSalary(10000,2,7);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for baseSalary is less than zero")]
        public void BaseSalary_Less_Than_Zero()
        {
            Salary sal = new Salary();
            int salary = sal.CalculateSalary(-1, 2, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for BaseCoeff is less than zero")]
        public void BaseCoeff_Less_Than_Zero()
        {
            Salary sal = new Salary();
            int salary = sal.CalculateSalary(10000, -1, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for Level is less than zero")]
        public void Level_Less_Than_Zero()
        {
            Salary sal = new Salary();
            int salary = sal.CalculateSalary(10000, 2, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for BaseSalary is more than specified in the task")]
        public void BaseSalary_More_Than_Task()
        {
            Salary sal = new Salary();
            int salary = sal.CalculateSalary(300000, 2, 5);
        }

        [TestMethod]
        public void Salary_Is_Correct_In_First_Condition()
        {
            Salary sal = new Salary();
            int salary = sal.CalculateSalary(10000, 2, 1);
            Assert.AreEqual(20000, salary, "Must be correct salary if baseCoeff<2 and baseCoeff>5");
        }

        [TestMethod]
        public void Salary_Is_Correct_In_Second_Condition()
        {
            Salary sal = new Salary();
            int salary = sal.CalculateSalary(10000, 2, 3);
            Assert.AreEqual(120000, salary, "Must be correct salary if baseCoeff>2 and baseCoeff<5");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for baseSalary is equal to zero")]
        public void BaseSalary_Is_Equal_to_Zero()
        {
            Salary sal = new Salary();
            int salary = sal.CalculateSalary(0, 2, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for BaseCoeff is equal to zero")]
        public void BaseCoeff_Is_Equal_to_Zero()
        {
            Salary sal = new Salary();
            int salary = sal.CalculateSalary(10000, 0, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Must be exception for Level is equal to zero")]
        public void Level_Is_Equal_to_Zero()
        {
            Salary sal = new Salary();
            int salary = sal.CalculateSalary(10000, 2, 0);
        }


    }
}
