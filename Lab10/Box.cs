class Box
{
    private double length;
    private double width;
    private double height;
    private double weight;

    public Box() : this(Random.Shared.NextDouble() * 10, Random.Shared.NextDouble() * 10, Random.Shared.NextDouble() * 10, Random.Shared.NextDouble() * 10)
    {
    }

    public Box(double length, double width, double height, double weight)
    {
        this.length = length;
        this.width = width;
        this.height = height;
        this.weight = weight;
    }

    public double Length
    {
        get { return length; }
    }

    public double Width
    {
        get { return width; }
    }

    public double Height
    {
        get { return height; }
    }

    public double Weight
    {
        get { return weight; }
    }

    public double GetVolume()
    {
        return length * height * weight;
    }
}
