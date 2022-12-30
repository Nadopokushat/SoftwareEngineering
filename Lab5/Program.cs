#region Task1
uint numberOfDays = 10;
double[] trainingDays = new double[numberOfDays];
trainingDays[0] = 10d; // First training day
for (int i = 1; i < numberOfDays; i++)
{
    trainingDays[i] = trainingDays[i - 1] * 1.1;
}
for (int i = 0; i < numberOfDays; i++)
{
    Console.WriteLine($"Day {i + 1}, distance: {trainingDays[i]:f2} km.");
}
double totalDistance = 0;
foreach (double day in trainingDays)
{
    totalDistance += day;
}
Console.WriteLine($"Total distance in {numberOfDays} days: {totalDistance:f2} km.");
#endregion

#region Task2
Console.WriteLine();
uint number = 0;
do
{
    Console.Write("Enter a number: ");
    number = uint.Parse(Console.ReadLine());
} while (number == 0);
Console.WriteLine($"The average of all integers between 1 and {number} is {GetAverage(number)}.");

static double GetAverage(uint number)
{
    if (number == 0)
    {
        throw new ArgumentException("Number cannot be 0.");
    }

    double sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum / number;
}
#endregion

#region Task3
Console.WriteLine();
do
{
    Console.Write("Enter a number: ");
    number = uint.Parse(Console.ReadLine());
} while (number == 0);
if (IsPerfectNumber(number))
{
    Console.WriteLine($"{number} is a perfect number.");
}
else
{
    Console.WriteLine($"{number} is not a perfect number.");
}

static bool IsPerfectNumber(uint number)
{
    List<int> divisors = new List<int>();

    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            divisors.Add(i);
        }
    }
    return divisors.Sum() == number;
}
#endregion

#region Task4
Console.WriteLine();
int[] numbers = new int[10];
for (int i = 100, j = 0; j < 10; i++)
{
    if (i % 10 == 7 && i % 9 == 0)
    {
        numbers[j] = i;
        j++;
    }
}
foreach (int i in numbers)
{
    Console.Write($"{i} ");
}
Console.WriteLine();
#endregion

#region Task5
Console.WriteLine();
do
{
    Console.Write("Enter a number: ");
    number = uint.Parse(Console.ReadLine());
} while (number == 0);
number = (uint)Math.Sqrt(number) + 1;
Console.WriteLine($"Square of a natural number: {Math.Pow(number, 2)}");
#endregion