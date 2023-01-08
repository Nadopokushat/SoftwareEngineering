#region Task1
using Triangle;

Console.WriteLine("e = {0:f1}\npi = {1:f}", Math.E, Math.PI);
#endregion

#region Task2
/*
 * Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2));
 * x1 * x2 + x1 * x3 + x2 * x3;
 * v0 * t + (a * Math.Pow(t, 2)) / 2;
 * m * Math.Pow(v, 2) / 2 + m * g * h;
 * 1 / R1 + 1 / R2;
 * m * g * Math.Cos(L);
 * 2 * Math.PI * R;
 * Math.Pow(b, 2) - 4 * a * c;
 * y * m1 * m2 / Math.Pow(r, 2);
 * Math.Pow(I, 2) * R;
 * a * b * Math.Sin(c);
 * Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(c));
 * (a * d + b * c) / (a * d);
 * Math.Sqrt(1 / Math.Pow(Math.Sin(x), 2));
 * 1 / Math.Sqrt(a * Math.Pow(x, 2) + b * x + c);
 * (Math.Sqrt(x +1) + Math.Sqrt(x - 1)) / (2 * Math.Sqrt(x));
 * Math.Abs(x) + Math.Abs(x + 1);
 * Math.Abs(1 - Math.Abs(x));
 */
#endregion

#region Task3
static double Z(double x, double y)
{
    return Math.Pow(x, 3) - 2.5 * x * y + 1.78 * x * x - 2.5 * y + 1;
}
#endregion

#region Task4
Console.WriteLine();
Console.Write("Enter leg A: ");
double legA = double.Parse(Console.ReadLine());
Console.Write("Enter leg A: ");
double legB = double.Parse(Console.ReadLine());

RightTriangle triangle = new RightTriangle(legA, legB);

Console.WriteLine($"Triangle perimeter is {triangle.GetPerimeter():f2}");
#endregion