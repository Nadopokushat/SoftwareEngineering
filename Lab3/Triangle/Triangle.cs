namespace Triangle;

abstract class Triangle
{
    private protected double sideA;
    private protected double sideB;
    private protected double sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if ((sideA <= 0) || (sideB <= 0) || (sideC <= 0))
        {
            throw new ArgumentException("The side of triangle cannot be 0 or be a negative number.");
        }
        else if ((sideA + sideB <= sideC) || (sideA + sideC <= sideB) || (sideB + sideC <= sideA))
        {
            throw new ArgumentException("Any two sides of a triangle cannot be less than or equal to the third side.");
        }

        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public abstract double GetPerimeter();
}
