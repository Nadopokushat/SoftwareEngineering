namespace Quadrilateral;

abstract class Quadrilateral
{
    private protected double a;
    private protected double b;

    public Quadrilateral(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public double GetPerimeter() => 2 * a + 2 * b;
    public double GetArea() => a * b;
}
