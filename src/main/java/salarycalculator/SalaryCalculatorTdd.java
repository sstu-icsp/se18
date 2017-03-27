package salarycalculator;

public class SalaryCalculatorTdd {

    private double baseSalary;
    private double multiplier;
    private int employeeLevel;

    public void setEmployeeLevel(int employeeLevel) {
        if(checkParameter(employeeLevel, "\"Уровень сотрудника должен быть не отрицательным числом\"")){
            if(!isLevelMoreSix(employeeLevel)) {
                this.employeeLevel = employeeLevel;
            }
        }
    }

    public void setMultiplier(double multiplier) {
        if(checkParameter(multiplier, "\"Коэффициент должен быть не отрицательным числом\"")){
            this.multiplier = multiplier;
        }
    }

    public void setBaseSalary(double baseSalary) {
      if(checkParameter(baseSalary, "\"Зарплата должна быть не отрицательным числом\"")){
           this.baseSalary = baseSalary;
      }
    }

    private boolean isNegativeNumber(double parameter) {
        return parameter < 0;
    }

    private boolean isNegativeNumber(int parameter) {
        return parameter < 0;
    }

    private boolean checkParameter(double parameter,String errorMessage){
        if(!isNegativeNumber(parameter)) {
            return true;
        } else throw new Error(errorMessage);
    }

    private boolean checkParameter(int parameter,String errorMessage){
        if(!isNegativeNumber(parameter)) {
            return true;
        } else throw new Error(errorMessage);
    }

    public boolean isLevelMoreSix(int employeeLevel){
         if(employeeLevel > 6){
            throw new Error("Уровень не должен превышать 6");
         } else return false;
    }

    public boolean isLevelRangeTwoToFive(){
        return (this.employeeLevel > 2  &&
                this.employeeLevel < 5);
    }

    public boolean isBaseSalaryExcedeedMaxSalary(){
        double maxSalary = 50000 * this.employeeLevel;
        if(baseSalary > maxSalary){
            throw new Error("Базовая зарплата превышает максимальную зарплату");
        } else return false;
    }

    public double getSalaryDependingOnValue(int value){
        return  this.baseSalary * (Math.pow(multiplier, employeeLevel  + value ));
    }

    public double calculateSalary(){
      if(isLevelRangeTwoToFive()){
          return (getSalaryDependingOnValue(0) + getSalaryDependingOnValue(1)) / 2;
      } else return getSalaryDependingOnValue(0);
    }
}

