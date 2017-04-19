using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarytesting
{
    public class Salary
    {
        private float base_salary;
        private float base_coefficient;
        private int level;
        static void Main(string[] args)
        {
        }
        public Salary(float base_salary, float base_coefficient, int level)
        {
            if (level>6)
                throw new ArgumentException("Ошибка! Уровень не может быть больше 6!");
            if (base_salary < 0 || base_coefficient < 0 || level < 0 )
                throw new ArgumentException("Ошибка! Параметры расчета не могут быть меньше 0");
            if (base_salary > 50000*level)
                throw new ArgumentException("Ошибка! Базовая зарплата не должна превышать значение, рассчитываемое по формуле 50.000 * Уровень!");

            this.base_salary = base_salary;
            this.base_coefficient = base_coefficient;
            this.level = level;

        }
        public double SalaryCalculator()
        {
            if (level > 2 && level < 5)
            {
                return (((base_salary * Math.Pow(base_coefficient, level)) + (base_salary * Math.Pow(base_coefficient, level + 1))) / 2);
            }
            else return (base_salary * Math.Pow(base_coefficient, level));
        }
    }
}
