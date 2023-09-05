namespace InterfaceExample
{
    public class CreatureManager
    {
        public CreatureManager()
        {
            
        }
        public IAnimal GetAnimalType(AnimalType creature)
        {
            switch (creature)
            {
                case AnimalType.Dog:
                    return new Dog();
                case AnimalType.Bird:
                    return new Duck();
                case AnimalType.Walrus:
                    return new Walrus();
                default:
                    return null;
            }
        }
    }
}
