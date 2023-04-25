using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itumelengRecipeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to the recipe app!");
            

            Recipe.storeRecipe();
            Recipe.display();
            Recipe.scaling();

            Console.WriteLine("Do you want to clear the recipe? ");
            choice=Console.ReadLine();

            if(choice == "yes")
            {
                Clear.clear();
                Recipe.storeRecipe();

            }
            else
            {
                Console.WriteLine("Thanks for using our app! ");
            }
            Console.ReadLine();
        }
    }
}
