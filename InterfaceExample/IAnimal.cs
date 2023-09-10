namespace InterfaceExample
{
    public interface IAnimal
    {
        public string MakeSound();
        public bool Move(MovementType move);
        public bool Eat(FoodType food);
        public string Name { get; set; }

    }

    public enum AnimalType
    {
        Dog,
        Bird,
        Walrus,
        Cat
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
