namespace InterfaceExample
{
    public class Dog : IAnimal
    {
        public Dog()
        {
            Name = "Dog";
        }
        public string Name { get; set; }

        public bool Eat(FoodType food)
        {
            switch (food)
            {
                case FoodType.Meat:
                    return true;
                case FoodType.Fish:
                    return true;
                case FoodType.Vegetables:
                    return false;
                case FoodType.Fruits:
                    return false;
                default:
                    return false;
            }

        }

        public string MakeSound()
        {
            return "Bark! Bark! Bark!";
        }

        public bool Move(MovementType move)
        {
            switch (move)
            {
                case MovementType.Walk:
                    return true;
                case MovementType.Fly:
                    return false;
                case MovementType.Swim:
                    return true;
                default:
                    return false;
            }
        }
    }
}
