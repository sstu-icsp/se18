import salarycalculator.SalaryCalculatorTdd;
import org.junit.Assert;
import org.junit.Test;

public class SalaryCalculatorTddTests extends Assert{

    SalaryCalculatorTdd salaryCalculatorTdd = new SalaryCalculatorTdd();

    @Test(expected = Error.class)
    public void shoudThrowErrorIfSalaryIsNegativeNumber() {
      salaryCalculatorTdd.setBaseSalary(-1);
    }

    @Test(expected = Error.class)
    public void shouldThrowErrorIfMultiplierIsNegativeNumber() {
      salaryCalculatorTdd.setMultiplier(-1);
    }

    @Test(expected = Error.class)
    public void shouldThrowErrorIfLevelIsNegativeNumber(){
      salaryCalculatorTdd.setEmployeeLevel(-1);
    }

    @Test
    public void setValueIfSalaryEqualsZero() {
      salaryCalculatorTdd.setBaseSalary(0);
    }

    @Test
    public void setValueIfMultiplierEqualsZero() {
      salaryCalculatorTdd.setMultiplier(0);
    }

    @Test
    public void setValueIfLevelEqualsZero() {
      salaryCalculatorTdd.setEmployeeLevel(0);
    }

    @Test
    public void setValueIfSalaryIsPositive() {
        salaryCalculatorTdd.setBaseSalary(1);
    }

    @Test
    public void setValueIfMultiplierIsPositive() {
        salaryCalculatorTdd.setMultiplier(1);
    }

    @Test
    public void setValueIfLevelIsPositive() {
        salaryCalculatorTdd.setEmployeeLevel(1);
    }

    @Test(expected = Error.class)
    public void shouldThrowErrorIfLevelMoreSix(){
      salaryCalculatorTdd.setEmployeeLevel(7);
    }

    @Test
    public void setValueIfEmployeeLevelLessSix(){
        salaryCalculatorTdd.setEmployeeLevel(4);
    }

    @Test
    public void levelIsNotIncludedIsInRangeOfTwoToFiveIfLevelLessTwo(){
      salaryCalculatorTdd.setEmployeeLevel(1);

      assertFalse(salaryCalculatorTdd.isLevelRangeTwoToFive());
    }

    @Test
    public void levelIsNotIncludedOfTwoToFiveIfLevelMoreFive(){
        salaryCalculatorTdd.setEmployeeLevel(6);

        assertFalse(salaryCalculatorTdd.isLevelRangeTwoToFive());
    }

    @Test(expected = Error.class)
    public void shouldErrorIfBaseSalaryExceedsTheMaximumSalary(){
        salaryCalculatorTdd.setEmployeeLevel(3);
        salaryCalculatorTdd.setBaseSalary(180000);

        salaryCalculatorTdd.isBaseSalaryExcedeedMaxSalary();
    }

    @Test
    public void baseSalaryNotExceedMaximumSalary(){
        salaryCalculatorTdd.setEmployeeLevel(3);
        salaryCalculatorTdd.setBaseSalary(10000);

        assertFalse(salaryCalculatorTdd.isBaseSalaryExcedeedMaxSalary());
    }

    @Test
    public void employeeLevelIsInRangeFromTwoToFive(){
        salaryCalculatorTdd.setEmployeeLevel(3);

        assertTrue(salaryCalculatorTdd.isLevelRangeTwoToFive());
    }

    @Test
    public void successfullyCalculatedSalaryIfLevelIsInRangeOfTwoToFive(){
        salaryCalculatorTdd.setEmployeeLevel(3);
        salaryCalculatorTdd.setBaseSalary(20000);
        salaryCalculatorTdd.setMultiplier(2);

        double resultSalary = salaryCalculatorTdd.calculateSalary();

        assertTrue(resultSalary == 240000);
    }

    @Test
    public void successfullyCalculatedSalaryIfLevelIsNotInRangeOfTwoToFive(){
        salaryCalculatorTdd.setEmployeeLevel(1);
        salaryCalculatorTdd.setBaseSalary(30000);
        salaryCalculatorTdd.setMultiplier(3);

        double resultSalary = salaryCalculatorTdd.calculateSalary();

        assertTrue(resultSalary == 90000);
    }
}
