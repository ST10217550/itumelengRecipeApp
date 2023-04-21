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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to the recipe app!");
            

            Recipe.storeRecipe();
            Recipe.display();
            Console.ReadLine();
        }
    }
}
