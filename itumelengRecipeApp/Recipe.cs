using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace itumelengRecipeApp
{
    internal class Recipe
    {
        private static int numOfIng = 0;
        private static int numOfSteps = 0;
        private static String nameOfRecipe;
        private static String nameOfIng;
        private static int quantityOfIng;
        private static String unitOfMesur;
        private static String steps;
        private static String[] nameOfRecArray;
        private static String[] nameOfIngArray;
        private static int[] quantityOfRecArray;
        private static String[] unitOfMesurArray;
        private static String[] stepsArray;




        public static void storeRecipe()
        {
            Console.WriteLine("Enter the name of your recipe: ");
            nameOfRecipe = Console.ReadLine();


            Console.WriteLine("Enter number of ingridents needed for your recipe: ");
            numOfIng = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < numOfIng; i++)
            {
                Console.WriteLine("Enter the first igredient: ");
                nameOfIng = Console.ReadLine();
                nameOfIngArray[i] = nameOfIng;

                Console.WriteLine("Enter the quantity of the ingredient: ");
                quantityOfIng = Convert.ToInt32(Console.ReadLine());
                quantityOfRecArray[i] = quantityOfIng;

                Console.WriteLine("Enter the unit of measurement: ");
                unitOfMesur = Console.ReadLine();
                unitOfMesurArray[i] = unitOfMesur;

                Console.WriteLine("Your ingredient has been successfully added! ");


            }

            Console.WriteLine("Enter the number of steps :");
            numOfSteps= Convert.ToInt32(Console.ReadLine());

            for(int j = 0; j < numOfSteps; j++)
            {
                Console.WriteLine("Enter Step " + (j));
                steps = Console.ReadLine();
                stepsArray[j] = steps;

            }





        }
  
        public static void display(String nameOfRecipe)
        {
            
        }
        

    }

    internal class pritave
    {
    }
}
