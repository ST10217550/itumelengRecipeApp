using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itumelengRecipeApp
{
    internal class Recipe
    {
        private static int numOfIng = 0;
        private static String nameOfRecipe;
        private static String nameOfIng;
        private static int quantityOfIng;
        private static String unitOfMesur;
        

        public static void storeRecipe()
        {
            Console.WriteLine("Enter the name of your recipe: ");
            nameOfRecipe = Console.ReadLine();

            Console.WriteLine("Enter number of ingridents needed for your recipe: ");
            numOfIng = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < numOfIng; i++)
            {
                Console.WriteLine("Enter the first igredient: ");
                nameOfIng= Console.ReadLine();

                Console.WriteLine("Enter the quantity of the ingredient: ");
                quantityOfIng = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the unit of measurement: ");
                unitOfMesur = Console.ReadLine();

            }

        }

    }

    internal class pritave
    {
    }
}
