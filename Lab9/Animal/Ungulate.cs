using Lab9.Enclosure;

namespace Lab9.Animal;

class Ungulate : Animal
{
    public Ungulate(string name, float weight, byte age) : base(name, weight, age)
    {
    }

    public override Type GetRequiredEnclosureType()
    {
        return new Open().GetType();
    }
}
