package com.salary.testdriven.test;

import com.salary.testdriven.Salary;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

public class SalaryTest {
    @Test
    void testCalcOutOfBoundsSalary() {
        assertThrows(IllegalArgumentException.class, () -> { new Salary(500000, 2, 1); });
    }

    @Test
    void testCalcOutOfBoundsLevel() {
        assertThrows(IllegalArgumentException.class, () -> { new Salary(15, 2, -1); });
        assertThrows(IllegalArgumentException.class, () -> { new Salary(15, 2, 0); });
        assertThrows(IllegalArgumentException.class, () -> { new Salary(15, 2, 7); });
    }

    @Test
    void testNegativeOrZeroBaseSalary() {
        assertThrows(IllegalArgumentException.class, () -> { new Salary(0, 2, 5); });
        assertThrows(IllegalArgumentException.class, () -> { new Salary(-1, 2, 5); });
    }

    @Test
    void testNegativeOrZeroBaseCoef() {
        assertThrows(IllegalArgumentException.class, () -> { new Salary(15, 0, 5); });
        assertThrows(IllegalArgumentException.class, () -> { new Salary(15, -1, 5); });
    }

    @Test
    public void testCalcFormula() {
        Salary salary = new Salary(50, 2, 1);
        assertEquals(100, salary.calc());
    }

    @Test
    public void testCalcFormulaFail() {
        Salary salary = new Salary(50, 2, 1);
        assertEquals(150, salary.calc());
    }

    @Test
    public void testCalcFormula2() {
        Salary salary = new Salary(50, 2, 3);
        assertEquals(600, salary.calc());
    }

    @Test
    public void testCalcFormula2Fail() {
        Salary salary = new Salary(50, 2, 3);
        assertEquals(400, salary.calc());
    }
}
