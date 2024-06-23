package SoftwareEngineering.Lab1.Shape;

public class Square implements IShape {
    private double a;

    public Square(double a) {
        this.a = a;
    }

    public double getPerimeter() {
        return a*4;
    }

    public double getArea() {
        return Math.pow(a, 2);
    }
}