namespace Triangle;

class RightTriangle : Triangle
{
    public RightTriangle(double legA, double legB): base(legA, legB, Math.Sqrt(Math.Pow(legA, 2) + Math.Pow(legB, 2))) { }

    public override double GetPerimeter()
    {
        return sideA + sideB + sideC;
    }
}
