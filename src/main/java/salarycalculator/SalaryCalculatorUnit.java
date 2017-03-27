package salarycalculator;

import exceptions.IncorrectLevelException;
import exceptions.IncorrectSalaryException;
import exceptions.MultiplierNegativeException;

public class SalaryCalculatorUnit {

    private double baseSalary;
    private double multiplier;
    private int employeeLevel;

    public void setBaseSalary(double baseSalary) throws IncorrectSalaryException {
        if (!isNegativeParameter(baseSalary)) {
            this.baseSalary = baseSalary;
        } else {
            throw new IncorrectSalaryException("Зарплата должна быть не отрицательным числом", baseSalary);
        }
    }

    public void setMultiplier(double multiplier) throws MultiplierNegativeException {
        if (!isNegativeParameter(multiplier)) {
            this.multiplier = multiplier;
        } else {
            throw new MultiplierNegativeException("Коэффициент должен быть не отрицательным числом", multiplier);
        }
    }

    public void setEmployeeLevel(int employeeLevel) throws IncorrectLevelException {
        if (!isNegativeParameter(employeeLevel)) {
            if(isLevelLessThanSix(employeeLevel)) {
                this.employeeLevel = employeeLevel;
            }
        } else {
            throw new IncorrectLevelException("Уровень работника должен быть не отрицательным числом", employeeLevel);
        }
    }

    public double calculateSalary() {
        double calclatedSalary;
        if (isRangeLevelOfTwoToFive()) {
            calclatedSalary = (baseSalary * (Math.pow(multiplier, employeeLevel)) + baseSalary * (Math.pow(multiplier, employeeLevel + 1))) / 2;
        } else {
            calclatedSalary = baseSalary * (Math.pow(multiplier, employeeLevel));
        }
        return calclatedSalary;
    }

    public boolean isNegativeParameter(double parameter) {
        return parameter < 0;
    }

    public boolean isNegativeParameter(int parameter) {
        return parameter < 0;
    }

    public boolean isLevelLessThanSix(int employeeLevel) throws IncorrectLevelException {
        if (employeeLevel <= 6) {
            return true;
        } else {
            throw new IncorrectLevelException("Уровень работника должен быть не больше 6", this.employeeLevel);
        }
    }

    public boolean isBaseSalaryExceededMaxSalary() {
        int maxSalary = 50000 * this.employeeLevel;
        return baseSalary > maxSalary;
    }

    public boolean isRangeLevelOfTwoToFive() {
        return this.employeeLevel > 2 &&
                this.employeeLevel < 5;
    }
}

