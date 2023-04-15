using Lab9.Animal;

namespace Lab9.Enclosure;

class Netted : Enclosure
{
    public override Type GetSupportedAnimalType()
    {
        return new Bird("", 0, 0).GetType();
    }
}
