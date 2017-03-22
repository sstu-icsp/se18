package calc;

import java.math.BigDecimal;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Calculator {
    private String string = "";

    public Calculator() {
    }

    public String getStr() {
        return string;
    }

    public void setStr(String str) {
        string = str;
    }

    public BigDecimal max_three_numbers(String str) throws IllegalArgumentException {
        BigDecimal val = new BigDecimal(0);
        try {
            if (parseString(str).length > 2) {
                throw new IllegalArgumentException("Количество переменных должно быть не больше 2");
            }
            for (String i : parseString(str)) {
                if (new BigDecimal(i).signum() == -1) throw new IllegalArgumentException("Не складывает отрицательные числа");
                val = val.add(new BigDecimal(i));
            }
        } catch (IllegalArgumentException e) {
            throw new IllegalArgumentException("Строка не валидна");
        }
        return val.setScale(16, BigDecimal.ROUND_HALF_EVEN);
    }

    public BigDecimal unlimited_number_count(String str) throws IllegalArgumentException {
        BigDecimal val = new BigDecimal(0);
        try {
            for (String i : parseString(str)) {
                if (new BigDecimal(i).signum() == -1) throw new IllegalArgumentException();
                val = val.add(new BigDecimal(i));
            }
        } catch (IllegalArgumentException e) {
            throw new NumberFormatException("Строка не валидна");
        }
        return val.setScale(16, BigDecimal.ROUND_HALF_EVEN);
    }

    public String[] parseString(String str) throws IllegalArgumentException {
        String delimiter;
        String numbers;
        Pattern p = Pattern.compile("^(//\\[)[^./\\d]+(\\]//).+");
        Matcher m = p.matcher(str);
        if (m.matches()) {
            delimiter = str.substring(str.indexOf('[') + 1, str.indexOf(']'));
            numbers = str.substring(str.lastIndexOf('/') + 1, str.length());
            if (!Character.isDigit(numbers.toCharArray()[0]) || !Character.isDigit(numbers.toCharArray()[numbers.length() - 1]))
                throw new IllegalArgumentException();
            return numbers.split(delimiter);
        }
        if (str.equals("")) return new String[0];
        if (!Character.isDigit(str.toCharArray()[0]) || !Character.isDigit(str.toCharArray()[str.length() - 1]))
            throw new IllegalArgumentException();
        return str.split(",|\n");
    }
}
