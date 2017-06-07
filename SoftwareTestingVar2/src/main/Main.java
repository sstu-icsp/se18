package main;

import Shapes.Dot;
import Shapes.Triangle;

public class Main {

    public static void main(String[] args) {
        Dot a = Dot.createDot();
        Dot b = Dot.createDot();
        Dot c = Dot.createDot();
        Triangle triangle = new Triangle(a, b, c);

        System.out.println("Area: " + triangle.area());
        System.out.println("Is Rectangular: " + triangle.isRectangular());
        System.out.println("Is Isosceles: " + triangle.isIsosceles());
        System.out.println("Is Arbitrary: " + triangle.isArbitrary());
    }
}
