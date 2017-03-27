package exceptions;

public class MultiplierNegativeException extends Exception{

    private double multiplier;

    public double getMultiplier() {
        return multiplier;
    }

    public MultiplierNegativeException(String message, double multiplier) {
        super(message);
        this.multiplier = multiplier;
    }
}
