namespace InterfaceExample
{
    public interface IAnimal
    {
        public string MakeSound();
        public bool Move(MovementType move);
        public bool Eat(FoodType food);

    }

    public enum AnimalType
    {
        Dog,
        Cat,
        Bird,
        Fish
    }

    public enum FoodType
    {
        Meat,
        Fish,
        Vegetables,
        Fruits
    }

    public enum MovementType
    {
        Walk,
        Fly,
        Swim
    }
}
