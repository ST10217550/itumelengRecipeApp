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
        private static String nameOfRecipe = null;
        private static String nameOfIng;
        private static int quantityOfIng;
        private static String unitOfMesur;
        private static String steps;



        public static void storeRecipe()
        {
            Console.WriteLine("Enter the name of your recipe: ");
            nameOfRecipe = Console.ReadLine();


            Console.WriteLine("Enter number of ingridents needed for your recipe: ");
            numOfIng = Convert.ToInt32(Console.ReadLine());

            private static String[] nameOfRecArray;
            private static String[] nameOfIngArray = new string[numOfIng];
            private static int[] quantityOfRecArray = new int[numOfIng];
            private static String[] unitOfMesurArray = new string[numOfIng];
            private static String[] stepsArray = new string[numOfIng];


            for (int i = 0; i < numOfIng; i++)
            {
                Console.WriteLine("Enter the name of ingredient: ");
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
  
        public static void display()
        {
            Console.BackgroundColor= ConsoleColor.White; 
            Console.ForegroundColor= ConsoleColor.Black;
            
            for(int k = 0; k < nameOfRecArray.Length; k++)
            {
                Console.WriteLine(nameOfRecArray[k] + "/n" + nameOfIngArray[k] + "/n" + quantityOfRecArray[k] + "/n" + unitOfMesurArray[k] + "/n" + stepsArray[k]);
            }
        }
        

    }

    internal class pritave
    {
    }
}
