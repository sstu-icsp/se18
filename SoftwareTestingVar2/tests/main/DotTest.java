package main;

import Shapes.Dot;
import org.testng.annotations.Test;

import java.io.ByteArrayInputStream;
import java.io.InputStream;
import java.util.InputMismatchException;
import java.util.NoSuchElementException;

import static org.testng.Assert.*;

public class DotTest {
    @Test
    public void testCreateDot()throws Exception {
        String input = "1\n-1";
        InputStream in = new ByteArrayInputStream(input.getBytes());
        System.setIn(in);
        assertEquals(new Dot(1,-1), Dot.createDot());
    }

    @Test(expectedExceptions = InputMismatchException.class)
    public void testCreateDotInputMismatchExceptionFirstParameter(){
        String input = "s\n-1";
        InputStream in = new ByteArrayInputStream(input.getBytes());
        System.setIn(in);
        assertEquals(new Dot(1,-1), Dot.createDot());
    }

    @Test(expectedExceptions = InputMismatchException.class)
    public void testCreateDotInputMismatchExceptionSecondParameter(){
        String input = "1\n!";
        InputStream in = new ByteArrayInputStream(input.getBytes());
        System.setIn(in);
        assertEquals(new Dot(1,-1), Dot.createDot());
    }

    @Test(expectedExceptions = NoSuchElementException.class)
    public void testCreateDotNoSuchElementExceptionFirstParameter(){
        String input = "\n-1";
        InputStream in = new ByteArrayInputStream(input.getBytes());
        System.setIn(in);
        assertEquals(new Dot(1,-1), Dot.createDot());
    }

    @Test(expectedExceptions = NoSuchElementException.class)
    public void testCreateDotNoSuchElementExceptionSecondParameter(){
        String input = "1\n";
        InputStream in = new ByteArrayInputStream(input.getBytes());
        System.setIn(in);
        assertEquals(new Dot(1,-1), Dot.createDot());
    }
}