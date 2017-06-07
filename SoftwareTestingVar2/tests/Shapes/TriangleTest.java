package Shapes;

import org.testng.annotations.Test;

import java.io.ByteArrayInputStream;
import java.io.InputStream;

import static org.testng.Assert.*;

public class TriangleTest {
    @Test
    public void testArea() throws Exception{
        Triangle triangle = new Triangle(new Dot(0,0), new Dot(0,5), new Dot(-5,0));
        assertEquals(12.5f, triangle.area());
    }

    @Test
    public void testIsRectangularTrue() throws Exception {
        Triangle triangle = new Triangle(new Dot(0,0), new Dot(0,5), new Dot(-5,0));
        assertEquals(true, triangle.isRectangular());
    }

    @Test
    public void testIsRectangularFalse() throws Exception {
        Triangle triangle = new Triangle(new Dot(0,0), new Dot(0,5), new Dot(-5,12));
        assertEquals(false, triangle.isRectangular());
    }

    @Test
    public void testIsIsoscelesTrue() throws Exception {
        Triangle triangle = new Triangle(new Dot(0,0), new Dot(0,5), new Dot(-5,0));
        assertEquals(true, triangle.isIsosceles());
    }

    @Test
    public void testIsIsoscelesFalse() throws Exception {
        Triangle triangle = new Triangle(new Dot(0,0), new Dot(1,5), new Dot(-5,0));
        assertEquals(false, triangle.isIsosceles());
    }

    @Test
    public void testIsArbitraryTrue() throws Exception {
        Triangle triangle = new Triangle(new Dot(0,0), new Dot(1,5), new Dot(-12,0));
        assertEquals(true, triangle.isArbitrary());
    }

    @Test
    public void testIsArbitraryFalseIsIsosceles() throws Exception {
        Triangle triangle = new Triangle(new Dot(0,0), new Dot(1,6), new Dot(6,1));
        assertEquals(false, triangle.isArbitrary());
    }

    @Test
    public void testIsArbitraryFalseIsRectangular() throws Exception {
        Triangle triangle = new Triangle(new Dot(0,0), new Dot(0,6), new Dot(1,0));
        assertEquals(false, triangle.isArbitrary());
    }

}