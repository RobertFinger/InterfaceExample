namespace InterfaceExample
{
    public class UserInterface
    {
        public UserInterface()
        {
            
        }

        public void FeedAnimal(bool likesFood, string name)
        {
            if(likesFood)
                Console.WriteLine($"Yum! {name}s like that food!");
            else
                Console.WriteLine($"Yuck! {name}s do not like that food!");
        }

        public FoodType GetAnimalFood()
        {
           Console.WriteLine("Select a food type:  1. Meat 2. Fish, 3. Vegetables, 4. Fruits");
           var foodTypeInput = Console.ReadLine();
            if (int.TryParse(foodTypeInput, out int result))
            {
                result--;  // decrement by 1 to match enum, humans don't like starting with 0.
                return (FoodType)result;
            }

            throw new Exception("Invalid GetAnimalFood input");
        }

        public MovementType MoveAnimal()
        {
            Console.WriteLine("How do you want your animal to move?  1. Walk 2. Fly, 3. Swim");
            var movementTypeInput = Console.ReadLine();
            if (int.TryParse(movementTypeInput, out int result))
            {
                result--;  // decrement by 1 to match enum, humans don't like starting with 0.
                return (MovementType)result;
            }

            throw new Exception("Invalid MoveAnimal input");
        }


        public AnimalType GetAnimalType()
        {
            Console.WriteLine("Select an animal type:  1. Dog 2. Duck, 3 Walrus");
            var animalTypeInput = Console.ReadLine();
            var result = 0;
            if(int.TryParse(animalTypeInput, out result))
            {
                result--;  // decrement by 1 to match enum, humans don't like starting with 0.
                
                return (AnimalType)result;
            }

            throw new Exception("Invalid animal type input");
        }   
    }
}
