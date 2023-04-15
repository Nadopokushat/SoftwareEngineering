using Lab9.Enclosure;
using Lab9.Animal;

void PlaceAnimal(Animal animal, Enclosure enclosure)
{
    if (animal == null || enclosure == null)
    {
        throw new ArgumentNullException("Animal and enclosure cannot be null.");
    }

    if ((animal.GetType() != enclosure.GetSupportedAnimalType()) && (enclosure.GetType() != animal.GetRequiredEnclosureType()))
    {
        throw new ArgumentException("Animal and enclosure must be compatible.");
    }

    animal.Enclosure = enclosure;
    enclosure.Animal = animal;
}