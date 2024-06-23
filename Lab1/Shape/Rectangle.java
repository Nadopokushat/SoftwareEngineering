package SoftwareEngineering.Lab1.Shape;

public class Rectangle implements Shape {
    private double a;
    private double b;

    public Rectangle(double a, double b) {
        this.a = a;
        this.b = b;
    }

    public double getPerimeter() {
        return a*2 + b*2;
    }

    public double getArea() {
        return a*b;
    }
}