using Lab9.Enclosure;

namespace Lab9.Animal;

class Waterfowl : Animal
{
    public Waterfowl(string name, float weight, byte age) : base(name, weight, age)
    {
    }

    public override Type GetRequiredEnclosureType()
    {
        return new Aquarium().GetType();
    }
}
