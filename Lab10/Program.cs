List<Box> boxes = new();
for (int i = 0; i < 10; i++)
{
    boxes.Add(new Box());
}

#region TaskA
double totalVolume = 0;
double totalWeight = 0;

foreach (Box box in boxes)
{
    totalVolume += box.GetVolume();
    totalWeight += box.Weight;
}
#endregion

#region TaskB
double lightestBox = boxes.Min(x => x.Weight);
double heaviestBox = boxes.Max(x => x.Weight);

Console.WriteLine($"The lightest box weighs {lightestBox:F4} and the heaviest box weighs {heaviestBox:F4}");
#endregion

#region TaskC
List<Box> boxesTaskC = new(boxes);

for (int i = boxesTaskC.Count - 1; i >= 0; i--)
{
    if (boxesTaskC[i].GetVolume() > 100.0)
    {
        boxesTaskC.Remove(boxesTaskC[i]);
    }
}
#endregion

#region TaskD
List<Box> lightBoxes = new();
List<Box> heavyBoxes = new();

double averageWeight = boxes.Average(x => x.Weight);

foreach (Box box in boxes)
{
    if (box.Weight <= averageWeight)
    {
        lightBoxes.Add(box);
    }
    else
    {
        heavyBoxes.Add(box);
    }
}
#endregion