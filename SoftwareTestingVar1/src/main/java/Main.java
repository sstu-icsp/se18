
import shapes.Triangle;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Triangle triangle = Triangle.createTriangle();
        System.out.println("Area: " + triangle.area());
        System.out.println("Is Rectangular: " + triangle.isRectangular());
        System.out.println("Is Isosceles: " + triangle.isIsosceles());
        System.out.println("Is Arbitrary: " + triangle.isArbitrary());
    }
}
