namespace Lab9.Enclosure;

using Lab9.Animal;

abstract class Enclosure
{
    private Animal? animal;

    public abstract Type GetSupportedAnimalType();
    private bool HasAnimal() => animal != null;

    public Animal Animal
    {
        get
        {
            if (!HasAnimal())
            {
                throw new Exception("There is no an animal in the enclosure.");
            }

            return animal!;
        }
        set
        {
            PlaceAnimal(value);
        }
    }

    private void PlaceAnimal(Animal animal)
    {
        if (HasAnimal())
        {
            throw new Exception("There is already an animal in the enclosure.");
        }

        this.animal = animal;
    }
}
