using Lab9.Enclosure;

namespace Lab9.Animal;

class Reptile : Animal
{
    public Reptile(string name, float weight, byte age) : base(name, weight, age)
    {
    }

    public override Type GetRequiredEnclosureType()
    {
        return new Terrarium().GetType();
    }
}
