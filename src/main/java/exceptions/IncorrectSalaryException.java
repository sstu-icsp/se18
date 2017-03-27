package exceptions;

public class IncorrectSalaryException extends Exception{

    private double salary;

    public double getSalary() {
        return salary;
    }

    public IncorrectSalaryException(String message, double salary) {

        super(message);
        this.salary = salary;
    }
}
