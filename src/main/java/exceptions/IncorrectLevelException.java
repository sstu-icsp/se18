package exceptions;

public class IncorrectLevelException extends Exception{

    private int level;

    public int getLevel() {
        return level;
    }

    public IncorrectLevelException(String message, int level) {
        super(message);
        this.level = level;
    }
}
