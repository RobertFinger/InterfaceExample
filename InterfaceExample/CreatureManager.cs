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
                case AnimalType.Cat:
                    return new Cat();
                default:
                    return null;
            }
        }

        public Dog GetDog(AnimalType creature)
        {
            return new Dog();
        }
    }
}
