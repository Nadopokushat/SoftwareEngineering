Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"You entered the number {number}\n{number} - that's the number you entered\n");

foreach (int i in new[] { 1, 13, 49 })
{
    Console.Write($"{i} ");
}
Console.WriteLine("\n");

foreach (int i in new[] { 50, 10 })
{
    Console.WriteLine(i);
}
Console.WriteLine();

Console.Write("Enter x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Enter y: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine($"7 cm\n{x} 25\n{x} {y}");