namespace InterfaceExample
{
    public class Cat : IAnimal
    {
        public Cat()
        {
            Name = "Cat";
        }

        public string Name { get; set; }

        public bool Eat(FoodType food)
        {
            throw new NotImplementedException();
        }

        public string MakeSound()
        {
            throw new NotImplementedException();
        }

        public bool Move(MovementType move)
        {
            throw new NotImplementedException();
        }
    }
}
