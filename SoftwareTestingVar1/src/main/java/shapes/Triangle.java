package shapes;

import java.util.Arrays;
import java.util.Scanner;


public class Triangle {
    private Dot a;
    private Dot b;
    private Dot c;

    public Dot getA() {
        return a;
    }

    public void setA(Dot a) {
        this.a = a;
    }

    public Dot getB() {
        return b;
    }

    public void setB(Dot b) {
        this.b = b;
    }

    public Dot getC() {
        return c;
    }

    public void setC(Dot c) {
        this.c = c;
    }

    public Triangle(Dot a, Dot b, Dot c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public static Triangle createTriangle() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter X coordinate of dot A: ");
        int x = scanner.nextInt();
        System.out.print("Enter Y coordinate of dot A: ");
        int y = scanner.nextInt();
        Dot A = new Dot(x, y);

        System.out.print("Enter X coordinate of dot B: ");
        x = scanner.nextInt();
        System.out.print("Enter Y coordinate of dot B: ");
        y = scanner.nextInt();
        Dot B = new Dot(x, y);

        System.out.print("Enter X coordinate of dot C: ");
        x = scanner.nextInt();
        System.out.print("Enter Y coordinate of dot C: ");
        y = scanner.nextInt();
        Dot C = new Dot(x, y);

        Triangle triangle = new Triangle(A, B, C);
        System.out.println("Triangle was successfully created!");
        return triangle;
    }

    public float area() {
        float area;
        area = Math.abs(0.5f*((a.getX()-c.getX())*(b.getY()-c.getY())-(b.getX()-c.getX())*(a.getY()-c.getY())));
        return area;
    }

    //считает квадраты сторон
    private float calcSquareSide(Dot firstDot, Dot secondDot) {
        float side;
        side = ((float) Math.pow((secondDot.getX()-firstDot.getX()), 2)) + (float)(Math.pow(secondDot.getY()-firstDot.getY(), 2));
        return side;
    }

    private float[] sortSides() {
        float[] sides = new float[]{calcSquareSide(getA(), getB()), calcSquareSide(getB(), getC()), calcSquareSide(getA(), getC())};
        Arrays.sort(sides);
        return sides;
    }

    //прямоугольный
    public boolean isRectangular() {
        float[] sides = sortSides();
        float sideAB = sides[0];
        float sideBC = sides[1];
        float sideAC = sides[2];

        if (sideAB + sideBC == sideAC)
            return true;
        else
            return false;
    }

    //равнобедренный
    public boolean isIsosceles() {
        float[] sides = sortSides();
        float sideAB = sides[0];
        float sideBC = sides[1];
        float sideAC = sides[2];

        if (sideAB == sideBC)
            return true;
        else
            return false;
    }

    //произвольный
    public boolean isArbitrary() {
        if(!isIsosceles() && !isRectangular())
            return true;
        else
            return false;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        Triangle triangle = (Triangle) o;

        if (a != null ? !a.equals(triangle.a) : triangle.a != null) return false;
        if (b != null ? !b.equals(triangle.b) : triangle.b != null) return false;
        return c != null ? c.equals(triangle.c) : triangle.c == null;
    }

    @Override
    public int hashCode() {
        int result = a != null ? a.hashCode() : 0;
        result = 31 * result + (b != null ? b.hashCode() : 0);
        result = 31 * result + (c != null ? c.hashCode() : 0);
        return result;
    }
}