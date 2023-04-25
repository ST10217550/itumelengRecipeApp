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
        private static String[] nameOfIngArray;
        private static int[] quantityOfRecArray;
        private static String[] unitOfMesurArray;
        private static String[] stepsArray;


        public int NumOfIng
        {
            get { return numOfIng; }
            set { numOfIng = value; }
        }

        public String NameofRecipe
        {
            get { return nameOfRecipe; }
            set { nameOfRecipe = value; }
        }

        public String NameOfIng
        {
            get { return nameOfIng; }
            set
            {
                nameOfIng = value;
            }
        }

        public int QuantityOfIng
        {
            get { return quantityOfIng; }
            set { quantityOfIng = value; }
        }

        public string UnitOfMesur
        {
            get { return unitOfMesur; }
            set { unitOfMesur = value; }
        }

        public int NumOfSteps
        {
            get { return numOfSteps; }
            set
            {
                numOfSteps = value;
            }
        }

       

        public static void storeRecipe()
        {
            Console.WriteLine("Enter the name of your recipe: ");
            nameOfRecipe = Console.ReadLine();
            


            Console.WriteLine("Enter number of ingridents needed for your recipe: ");
            numOfIng = Convert.ToInt32(Console.ReadLine());
            nameOfIngArray= new string[numOfIng];
            quantityOfRecArray = new int[numOfIng];
            unitOfMesurArray = new string[numOfIng];


            
            for (int i = 0; i < numOfIng; i++)
            {
                Console.WriteLine("Enter the name of ingredient: ");
                nameOfIngArray[i] = Console.ReadLine();

                Console.WriteLine("Enter the quantity of the ingredient: ");
                quantityOfRecArray[i] = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter the unit of measurement: ");
                unitOfMesurArray[i] = Console.ReadLine() ;

                Console.WriteLine("Your ingredient has been successfully added! ");


            }

            Console.WriteLine("Enter the number of steps :");
            numOfSteps= Convert.ToInt32(Console.ReadLine());
            stepsArray = new string[numOfSteps];

            for(int j = 1; j < numOfSteps; j++)
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
            
            for(int k = 0; k < nameOfIng.Length; k++)
            {
                Console.WriteLine(nameOfRecipe + "\n" + nameOfIngArray[k] + "\n" + quantityOfRecArray[k] + "\n" + unitOfMesurArray[k] + "\n Steps: " + stepsArray[k]);
            }
        }

        public int scale(int scaleValue)
        {
            int finalscale = 0;

            Console.WriteLine("Enter the scale you would like to convert the recipe: ");
            scaleValue = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nameOfRecipe.Length; i++)
            {

            }

            return finalscale;
        }


    }

    internal class pritave
    {
    }
}
