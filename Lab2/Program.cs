#region Task1-2
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"You entered the number {number}\n{number} - that's the number you entered\n");
#endregion

#region Task3
foreach (int i in new[] { 1, 13, 49 })
{
    Console.Write($"{i} ");
}
Console.WriteLine("\n");
#endregion

#region Task4
foreach (int i in new[] { 50, 10 })
{
    Console.WriteLine(i);
}
Console.WriteLine();
#endregion

#region Task5
Console.Write("Enter x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Enter y: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine($"7 cm\n{x} 25\n{x} {y}");
#endregion