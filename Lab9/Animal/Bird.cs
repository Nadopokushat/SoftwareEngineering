using Lab9.Enclosure;

namespace Lab9.Animal;

class Bird : Animal
{
    public Bird(string name, float weight, byte age) : base(name, weight, age)
    {
    }

    public override Type GetRequiredEnclosureType()
    {
        return new Netted().GetType();
    }
}
