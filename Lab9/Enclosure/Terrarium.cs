using Lab9.Animal;

namespace Lab9.Enclosure;

class Terrarium : Enclosure
{
    public override Type GetSupportedAnimalType()
    {
        return new Reptile("", 0, 0).GetType();
    }
}
