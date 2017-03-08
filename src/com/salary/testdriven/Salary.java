package com.salary.testdriven;

public class Salary {
    double baseSalary;
    double baseCoef;
    int level;

    public Salary(double baseSalary, double baseCoef, int level) {
        if (level < 1 || level > 6)
            throw new IllegalArgumentException("Level must be in [1,6] range");
        if (baseSalary <= 0)
            throw new IllegalArgumentException("Salary must be positive");
        if (baseCoef <= 0)
            throw new IllegalArgumentException("Coef must be positive");
        if (baseSalary > 50000 * level)
            throw new IllegalArgumentException("Base salary cannot be more than (50000 * level)");

        this.baseSalary = baseSalary;
        this.baseCoef = baseCoef;
        this.level = level;
    }

    public double calc() {
        if (level > 2 && level < 5) {
            return (((baseSalary * Math.pow(baseCoef, level)) + (baseSalary * Math.pow(baseCoef, level+1))) / 2);
        } else return (baseSalary * Math.pow(baseCoef, level));
    }
}
