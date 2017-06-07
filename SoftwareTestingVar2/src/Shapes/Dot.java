package Shapes;

import java.util.Scanner;

public class Dot {
    private int x;
    private int y;

    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }

    public int getY() {
        return y;
    }

    public void setY(int y) {
        this.y = y;
    }

    public Dot (int x, int y) {
        this.x = x;
        this.y = y;
    }

    @Override
    public boolean equals(Object obj) {
        Dot dot=(Dot)obj;
        if(this.getX() == dot.getX() && this.getY() == dot.getY()) return true;
        return false;
    }

    public static Dot createDot(){
        Scanner scanner = new Scanner((System.in));
        int x, y;
        System.out.print("Enter X coordinate of dot: ");
        x = scanner.nextInt();
        System.out.print("Enter Y coordinate of dot: ");
        y = scanner.nextInt();
        return new Dot(x,y);
    }

}
