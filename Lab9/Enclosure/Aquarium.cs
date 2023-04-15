using Lab9.Animal;

namespace Lab9.Enclosure;

class Aquarium : Enclosure
{
    public override Type GetSupportedAnimalType()
    {
        return new Waterfowl("", 0, 0).GetType();
    }
}
