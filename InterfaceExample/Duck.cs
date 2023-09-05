namespace InterfaceExample
{
    public class Duck : IAnimal
    {
        public Duck()
        {
            Name = "Duck";
        }
        public string Name { get; set; }
        public bool Eat(FoodType food)
        {
            switch (food)
            {
                case FoodType.Meat:
                    return false;
                case FoodType.Fish:
                    return true;
                case FoodType.Vegetables:
                    return true;
                case FoodType.Fruits:
                    return false;
                default:
                    return false;
            }

        }

        public string MakeSound()
        {
            return "Quack! Quack! Quack!";
        }

        public bool Move(MovementType move)
        {
            switch (move)
            {
                case MovementType.Walk:
                    return true;
                case MovementType.Fly:
                    return true;
                case MovementType.Swim:
                    return true;
                default:
                    return false;
            }
        }
    }
}
