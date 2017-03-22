package calc;

import org.junit.Assert;

import java.math.BigDecimal;

import static org.junit.Assert.*;

public class CalculatorTest {
    @org.junit.Test
    public void max_three_numbers() {
        Calculator calc = new Calculator();
        Assert.assertEquals(new BigDecimal("0.0000000000000000"), (calc.max_three_numbers("")));
        Assert.assertEquals(new BigDecimal("1.0000000000000000"), (calc.max_three_numbers("1")));
        Assert.assertEquals(new BigDecimal("1.2000000000000000"), (calc.max_three_numbers("1.2")));
        Assert.assertEquals(new BigDecimal("1.1111111111111111"), (calc.max_three_numbers("1.111111111111111123")));
    }

    @org.junit.Test
    public void max_three_numbers_comma() {
        Calculator calc = new Calculator();
        Assert.assertEquals(new BigDecimal("3.0000000000000000"), (calc.max_three_numbers("1,2")));
        Assert.assertEquals(new BigDecimal("2.5000000000000000"), (calc.max_three_numbers("1.3,1.2")));
    }

    @org.junit.Test
    public void max_three_numbers_transfer() {
        Calculator calc = new Calculator();
        Assert.assertEquals(new BigDecimal("3.0000000000000000"), (calc.max_three_numbers("1\n2")));
        Assert.assertEquals(new BigDecimal("2.5000000000000000"), (calc.max_three_numbers("1.3\n1.2")));
    }

    @org.junit.Test
    public void max_three_numbers_delimiter() {
        Calculator calc = new Calculator();
        Assert.assertEquals(new BigDecimal("3.0000000000000000"), (calc.max_three_numbers("//[f]//1f2")));
        Assert.assertEquals(new BigDecimal("2.5000000000000000"), (calc.max_three_numbers("//[ ]//1.3 1.2")));
    }

    @org.junit.Test
    public void max_three_numbers_negative() {
        Calculator calc = new Calculator();
        try {
            calc.max_three_numbers("-1,1");
            fail("IllegalArgumentException waited");
        } catch (IllegalArgumentException e) {
            e.getMessage();
        }
    }

    @org.junit.Test()
    public void max_three_numbers_rubbish_exception() {
        Calculator calc = new Calculator();
        try {
            calc.max_three_numbers(".1");
            fail("IllegalArgumentException waited");
        } catch (IllegalArgumentException e) {
            e.getMessage();
        }
    }

    @org.junit.Test
    public void unlimited_number_count() {
        Calculator calc = new Calculator();
        Assert.assertEquals(new BigDecimal("0.0000000000000000"), (calc.unlimited_number_count("")));
        Assert.assertEquals(new BigDecimal("1.0000000000000000"), (calc.unlimited_number_count("1")));
        Assert.assertEquals(new BigDecimal("1.2000000000000000"), (calc.unlimited_number_count("1.2")));
        Assert.assertEquals(new BigDecimal("1.1111111111111111"), (calc.unlimited_number_count("1.111111111111111123")));
    }

    @org.junit.Test
    public void unlimited_number_count_comma() {
        Calculator calc = new Calculator();
        Assert.assertEquals(new BigDecimal("4.1111111111111111"), (calc.unlimited_number_count("1.111111111111111123,2,1")));
    }

    @org.junit.Test
    public void unlimited_number_count_transfer() {
        Calculator calc = new Calculator();
        Assert.assertEquals(new BigDecimal("7.0000000000000000"), (calc.unlimited_number_count("1\n2\n4")));
        Assert.assertEquals(new BigDecimal("5.5000000000000000"), (calc.unlimited_number_count("1.3\n1.2\n3")));
    }

    @org.junit.Test
    public void unlimited_number_count_delimiter() {
        Calculator calc = new Calculator();
        Assert.assertEquals(new BigDecimal("3.0000000000000000"), (calc.unlimited_number_count("//[f]//1f2")));
        Assert.assertEquals(new BigDecimal("6.5000000000000000"), (calc.unlimited_number_count("//[ ]//1.3 1.2 4")));
    }

    @org.junit.Test
    public void unlimited_number_count_negative() {
        Calculator calc = new Calculator();
        try {
            calc.unlimited_number_count("-1,1,-2");
            fail("IllegalArgumentException waited");
        } catch (IllegalArgumentException e) {
            e.getMessage();
        }
    }

    @org.junit.Test()
    public void unlimited_number_count_exception() {
        Calculator calc = new Calculator();
        try {
            calc.unlimited_number_count("1,3,4.");
            fail("IllegalArgumentException waited");
        } catch (IllegalArgumentException e) {
            e.getMessage();
        }
    }
}