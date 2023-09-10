using System.Net.NetworkInformation;

namespace InterfaceExample
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var manager = new CreatureManager();
            var ui = new UserInterface();

            while (ui.SelectAnimal())
            {
                var input = ui.GetAnimalType();
                var animal = manager.GetAnimalType(input);
                var food = ui.GetAnimalFood();
                var likesFood = animal.Eat(food); 
                ui.FeedAnimal(likesFood, animal.Name);

                Console.Clear();
            }

            
     }

        
    }
}