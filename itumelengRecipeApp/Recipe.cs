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
        //variabes
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



        // my getters and setters 
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

       
        

        //methode to store the data of the recipe
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
  


        //method to display the recipe
        public static void display()
        {
            Console.BackgroundColor= ConsoleColor.White; 
            Console.ForegroundColor= ConsoleColor.Black;
            
            for(int k = 0; k < nameOfIngArray.Length; k++)
            {
                Console.WriteLine(nameOfRecipe + "\n" + nameOfIngArray[k] + "\n" + quantityOfRecArray[k] + "\n" + unitOfMesurArray[k] );
            }

            for(int n = 0;n < stepsArray.Length; n++)
            {
                Console.WriteLine("steps " + n + "\n" + stepsArray[n]);
            }
        }



        //method for scaling the recipe to disired size
        public static void scaling()
        {
            int scaleValue;
            int finalscale = 0;

            ConsoleColor color = ConsoleColor.DarkGreen;

            Console.WriteLine("Enter 1 is you would like to scale the quanity to half: " + "\n" +
                              "Enter 2 is you would like to scale the quanity to double: " + "\n" +
                              "Enter 3 is you would like to scale the quanity to triple: " + "\n");
            scaleValue = Convert.ToInt32(Console.ReadLine());

            if(scaleValue == 1)
            {
                for (int i = 0; i < nameOfIngArray.Length; i++)
                {
                    double [] quantityOfRecArray1 = new double[quantityOfRecArray.Length];
                    quantityOfRecArray1[i] = Convert.ToDouble(quantityOfRecArray[i]);
                    quantityOfRecArray1[i] *= 0.5;
                    Console.WriteLine(nameOfRecipe + "\n" + nameOfIngArray[i] + "\n" + quantityOfRecArray1[i] + "\n" + unitOfMesurArray[i]);
                }
                for (int n = 0; n < stepsArray.Length; n++)
                {
                    Console.WriteLine("steps " + n + "\n" + stepsArray[n]);
                }

            }

            else if(scaleValue == 2)
            {
                for (int i = 0; i < nameOfIngArray.Length; i++)
                {
                    quantityOfRecArray[i] *= 2;
                    Console.WriteLine(nameOfRecipe + "\n" + nameOfIngArray[i] + "\n" + quantityOfRecArray[i] + "\n" + unitOfMesurArray[i]);
                }

                for (int n = 0; n < stepsArray.Length; n++)
                {
                    Console.WriteLine("steps " + n + "\n" + stepsArray[n]);
                }

            }

            else
            {
                for (int i = 0; i < nameOfIngArray.Length; i++)
                {
                    quantityOfRecArray[i] *= 3;
                    Console.WriteLine(nameOfRecipe + "\n" + nameOfIngArray[i] + "\n" + quantityOfRecArray[i] + "\n" + unitOfMesurArray[i]);
                }

                for (int n = 0; n < stepsArray.Length; n++)
                {
                    Console.WriteLine("steps " + n + "\n" + stepsArray[n]);
                }

            }

           
        }


    }

    internal class pritave
    {
    }
}
