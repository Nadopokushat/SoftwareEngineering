#region Task1
Random random= new Random();
int[] numbers = new int[10];
for (int i = 0; i < 10; i++)
{
    numbers[i] = random.Next(-10, 21);
}

Console.Write("Even numbers: ");
foreach (int i in numbers)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
}

Console.WriteLine();
Console.Write("Odd numbers: ");
foreach (int i in numbers)
{
    if (i % 2 != 0)
    {
        Console.Write($"{i} ");
    }
}

Console.WriteLine();
Console.Write("Positive numbers: ");
foreach (int i in numbers)
{
    if (i >= 0)
    {
        Console.Write($"{i} ");
    }
}

Console.WriteLine();
Console.Write("Negative numbers: ");
foreach (int i in numbers)
{
    if (i < 0)
    {
        Console.Write($"{i} ");
    }
}

Console.WriteLine();
Console.Write("Single digit numbers: ");
foreach (int i in numbers)
{
    if (i / 10 == 0)
    {
        Console.Write($"{i} ");
    }
}

Console.WriteLine();
Console.Write("Double digit numbers: ");
foreach (int i in numbers)
{
    if (i / 10 != 0)
    {
        Console.Write($"{i} ");
    }
}
#endregion

#region Task2
Console.WriteLine();
double average = (numbers.Max() + numbers.Min()) / 2;
int counter = 0;
foreach (int i in numbers)
{
    if (i > average)
    {
        counter++;
    }
}

Console.WriteLine();
Console.Write("Indexes: ");
for (int i = 0; i < 10; i++)
{
    if (i > average)
    {
        Console.Write($"{i} ");
    }
}
#endregion

#region Task3
double[] realNumbers = new double[10];
for (int i = 0; i < 10; i++)
{
    realNumbers[i] = random.NextDouble() * random.Next(-10, 11);
}
average = realNumbers.Sum() / 10;
for (int i = 0; i < 10; i++)
{
    if (realNumbers[i] > 0)
    {
        realNumbers[i]++;
    }
    else if (realNumbers[i] < 0)
    {
        realNumbers[i]--;
    }
    else
    {
        realNumbers[i] = average;
    }
}
#endregion

#region Task4
int[,] numbers2 = new int[10, 10];
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        numbers2[i, j] = random.Next();
    }
}
int maxNumber = numbers2[0, 0];
int maxNumberX = 0;
int maxNumberY = 0;
int minNumber = numbers2[0, 0];
int minNumberX = 0;
int minNumberY = 0;
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        if (numbers2[i, j] > maxNumber)
        {
            maxNumber = numbers2[i, j];
            maxNumberX = i;
            maxNumberY = j;
        }
        else if (numbers2[i, j] < minNumber)
        {
            minNumber = numbers2[i, j];
            minNumberX = i;
            minNumberY = j;
        }
    }
}
#endregion

#region Task5
bool IsMagic(int[][] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i].Length != numbers.Length)
        {
            throw new ArgumentException("Not all lines are the same length.");
        }
    }

    int row0 = numbers[0].Sum();

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i].Sum() != row0)
        {
            return false;
        }
    }

    for (int j = 0; j < numbers.Length; j++)
    {
        int row = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            row += numbers[i][j];
        }

        if (row != row0)
        {
            return false;
        }
    }

    int diagonal1 = 0;
    int diagonal2 = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        diagonal1 += numbers[i][i];
        diagonal2 += numbers[numbers.Length - 1 - i][numbers.Length - 1 - i];
    }

    if (diagonal1 != row0 || diagonal2 != row0 )
    {
        return false;
    }

    return true;
}
Console.WriteLine();
#endregion