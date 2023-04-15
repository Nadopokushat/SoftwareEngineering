namespace Lab9.Animal;

using Lab9.Enclosure;

abstract class Animal
{
    private readonly string name;
    private readonly float weight;
    private readonly byte age;
    private Enclosure? enclosure;

    protected Animal(string name, float weight, byte age)
    {
        this.name = name;
        this.weight = weight;
        this.age = age;
    }

    public string Name { get { return name; } }
    public float Weight { get { return weight;} }
    public byte Age { get { return age;} }
    public abstract Type GetRequiredEnclosureType();
    public bool IsInEnclosure() => enclosure != null;

    public Enclosure Enclosure
    {
        get
        {
            if (!IsInEnclosure())
            {
                throw new Exception("The animal is not in an enclosure.");
            }

            return enclosure!;
        }
        set
        {          
            PlaceAnimal(value);
        }
    }

    private void PlaceAnimal(Enclosure enclosure)
    {
        if (IsInEnclosure())
        {
            throw new Exception("The animal is already in an enclosure.");
        }

        this.enclosure = enclosure;
    }
}
