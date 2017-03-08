package com.salary.classic.test;

import com.salary.classic.Salary;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;


class SalaryTest {
    @Test
    void testCalcFormula() {
        Salary salary = new Salary(50, 2, 2);
        assertEquals(200, salary.calc());
    }

    @Test
    void testCalcFormula2() {
        Salary salary = new Salary(50, 2, 4);
        assertEquals(1200, salary.calc());
    }

    @Test
    void testCalcOutOfBoundsSalary() {
        assertThrows(IllegalArgumentException.class, () -> { new Salary(100000, 2, 1); });
    }

    @Test
    void testCalcOutOfBoundsLevel() {
        assertThrows(IllegalArgumentException.class, () -> { new Salary(10, 2, -1); });
        assertThrows(IllegalArgumentException.class, () -> { new Salary(10, 2, 0); });
        assertThrows(IllegalArgumentException.class, () -> { new Salary(10, 2, 7); });
    }

    @Test
    void testNegativeOrZeroBaseSalary() {
        assertThrows(IllegalArgumentException.class, () -> { new Salary(0, 2, 5); });
        assertThrows(IllegalArgumentException.class, () -> { new Salary(-1, 2, 5); });
    }

    @Test
    void testNegativeOrZeroBaseCoef() {
        assertThrows(IllegalArgumentException.class, () -> { new Salary(10, 0, 5); });
        assertThrows(IllegalArgumentException.class, () -> { new Salary(10, -1, 5); });
    }
}