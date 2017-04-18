using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSalary
{
    public class Salary
    {
        public int CalculateSalary(int baseSalary, int baseCoeff, int level)
        {
            if (level > 6)
            {
                throw new ArgumentException();
            }

            if (baseSalary <= 0 || baseCoeff <= 0 || level <= 0)
            {
                throw new ArgumentException();
            }

            if (baseSalary > 50000 * level)
            {
                throw new ArgumentException();
            }

            int Salary = (int)(baseSalary * Math.Pow(baseCoeff, level));

            if (level > 2 && level < 5)
            {
                Salary = (int)(((baseSalary * Math.Pow(baseCoeff, level)) + (baseSalary * Math.Pow(baseCoeff, level+1))) / 2);
            }

            return Salary;
        }
    }
}
