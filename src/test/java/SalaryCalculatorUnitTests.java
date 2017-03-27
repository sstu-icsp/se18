 import salarycalculator.SalaryCalculatorUnit;
import exceptions.IncorrectLevelException;
import exceptions.MultiplierNegativeException;
import exceptions.IncorrectSalaryException;
import org.junit.Assert;
import org.junit.Test;

public class SalaryCalculatorUnitTests extends Assert {

    SalaryCalculatorUnit salaryCalculator = new SalaryCalculatorUnit();

    @Test(expected = IncorrectLevelException.class)
    public void shouldThrowExceptionIfEmployeeLevelNegative() throws IncorrectLevelException {
      salaryCalculator.setEmployeeLevel(-1);
    }

    @Test(expected = MultiplierNegativeException.class)
    public void shouldThrowExceptionIfMultiplierNegative() throws MultiplierNegativeException {
      salaryCalculator.setMultiplier(-1);
    }

    @Test(expected = IncorrectSalaryException.class)
    public void shouldThrowExceptionIfSalaryNegative() throws IncorrectSalaryException {
       salaryCalculator.setBaseSalary(-1);
    }

    @Test
    public void setValueIfEmployeeLevelIsPositive() throws Exception {
      salaryCalculator.setEmployeeLevel(1);
    }

    @Test
    public void setValueIfMultiplierIsPositive() throws Exception {
     salaryCalculator.setMultiplier(1);
    }

    @Test
    public void setValueIfBaseSalaryIsPositive() throws Exception {
      salaryCalculator.setBaseSalary(1);
    }

    @Test
    public void setValueIfEmployeeLevelIsEqualsZero() throws Exception {
        salaryCalculator.setEmployeeLevel(0);
    }

    @Test
    public void setValueIfMultiplierIsEqualsZero() throws Exception {
        salaryCalculator.setMultiplier(0);
    }

    @Test
    public void setValueIfBaseSalaryIsEqualsZero() throws Exception {
        salaryCalculator.setBaseSalary(0);
    }

    @Test(expected = IncorrectLevelException.class)
    public void shouldThrowExceptionIfLevelMoreThanSix() throws IncorrectLevelException {
        salaryCalculator.setEmployeeLevel(10);
    }

    @Test
    public void setValueIfEmployeeLevelLessThanSix() throws Exception {
        salaryCalculator.setEmployeeLevel(4);
    }

    @Test
    public void employeeLevelLessThanTwo() throws IncorrectLevelException {
        salaryCalculator.setEmployeeLevel(1);

        assertFalse(salaryCalculator.isRangeLevelOfTwoToFive());
    }

    @Test
    public void employeeLevelMoreThanFive() throws IncorrectLevelException {
        salaryCalculator.setEmployeeLevel(6);

        assertFalse(salaryCalculator.isRangeLevelOfTwoToFive());
    }

    @Test
    public void employeeLeveIsInRangeOfTwoToFive() throws IncorrectLevelException {
        salaryCalculator.setEmployeeLevel(3);

        assertTrue(salaryCalculator.isRangeLevelOfTwoToFive());
    }

    @Test
    public void salaryExceedsLimitValue() throws Exception {
      salaryCalculator.setEmployeeLevel(1);
      salaryCalculator.setBaseSalary(50500);

      assertTrue(salaryCalculator.isBaseSalaryExceededMaxSalary());
    }

    @Test
    public void salaryIsNotExceedsLimitValue() throws Exception {
     salaryCalculator.setEmployeeLevel(2);
     salaryCalculator.setBaseSalary(24000);

     assertFalse(salaryCalculator.isBaseSalaryExceededMaxSalary());
    }

    @Test
    public void successfullyCalculatedSalaryIfLevelIsInRangeOfTwoToFive() throws Exception {
       salaryCalculator.setEmployeeLevel(3);
       salaryCalculator.setBaseSalary(20000);
       salaryCalculator.setMultiplier(2);

       double resultSalary = salaryCalculator.calculateSalary();
       assertTrue(resultSalary == 240000);
    }

    @Test
    public void successfullyCalculatedSalaryIfLevelIsNotInRangeOfTwoToFive() throws Exception{
        salaryCalculator.setEmployeeLevel(1);
        salaryCalculator.setBaseSalary(30000);
        salaryCalculator.setMultiplier(2);

        double resultSalary = salaryCalculator.calculateSalary();
        assertTrue(resultSalary == 60000);
    }
}
