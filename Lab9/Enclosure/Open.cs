using Lab9.Animal;

namespace Lab9.Enclosure;

class Open : Enclosure
{
    public override Type GetSupportedAnimalType()
    {
        return new Ungulate("", 0, 0).GetType();
    }
}
