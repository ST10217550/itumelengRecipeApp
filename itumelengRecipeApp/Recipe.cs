using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
        private static  List<String> nameOfRecArray;
        private static List<String> nameOfIngArray;
        private static List<int> quantityOfRecArray;
        private static List<String> unitOfMesurArray;
        private static List<String> stepsArray;
        private static int scaleValue;



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

        public List<String> NameOfRecArray
        {
            get { return nameOfRecArray; }
            set { nameOfRecArray = value; }
        }

        public List<String> NameOfIngArray
        {
            get { return nameOfIngArray; }
            set { nameOfIngArray = value;}
        }

        public List<int> QuantityOfRecArray
        {
            get { return quantityOfRecArray; }
            set { quantityOfRecArray = value; }
        }

        public List<String> UnitOfMesurArray
        {
            get { return unitOfMesurArray; }
            set { unitOfMesurArray = value;}
        }

        public List<String> StepsArray
        {
            get { return stepsArray; }
            set
            {
                stepsArray = value;
            }
        }

       
        public static void menu()
        {
            String menu = null;

            Console.WriteLine("1. Enter recipe" + "\n" +
                              "2. Display all recipes" + "\n" +
                              "3. Display a recipe" + "\n" +
                              "4. Scaling");
            Console.ReadLine();


            while ((menu == "1") ||(menu == "2") ||(menu == "3")||(menu == "4") )
            {
                if(menu == "1")
                {
                    storeRecipe();
                }

                else if(menu == "2")
                {

                }

                else if(menu == "3")
                {

                }

                else
                {
                    Console.WriteLine("Thank you for using the app!");
                }
            }
        }

        //methode to store the data of the recipe
        public static void storeRecipe()
        {
            Console.WriteLine("Enter the name of your recipe: ");
            nameOfRecipe = Console.ReadLine();
            


            Console.WriteLine("Enter number of ingridents needed for your recipe: ");
            numOfIng = Convert.ToInt32(Console.ReadLine());
            nameOfIngArray = new List<string>(numOfIng);
            quantityOfRecArray = new List<int>(numOfIng);
            unitOfMesurArray = new List<String>(numOfIng);



            for (int i = 0; i < numOfIng; i++)
            {
                Console.WriteLine("Enter the name of ingredient: ");
                nameOfIngArray[i] = Console.ReadLine();

                Console.WriteLine("Enter the quantity of the ingredient: ");
                quantityOfRecArray[i] = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter the unit of measurement: ");
                unitOfMesurArray[i] = Console.ReadLine();

                Console.WriteLine("Your ingredient has been successfully added! ");


            }
            //entering number of steps
            Console.WriteLine("Enter the number of steps :");
            numOfSteps= Convert.ToInt32(Console.ReadLine());
            stepsArray = new List<string>(numOfSteps);

            for(int j = 1; j < numOfSteps; j++)
            {
                Console.WriteLine("Enter Step " + (j));
                steps = Console.ReadLine();
                stepsArray[j] = steps;

            }

        }
  


        //method to display the recipe
        public static   String display(string search)
        {
            Console.BackgroundColor= ConsoleColor.White; 
            Console.ForegroundColor= ConsoleColor.Black;

            Console.WriteLine("Enter the name of recipe you are looking for:");
            search = Console.ReadLine();

            for(int k = 0; k < nameOfRecArray.Count; k++)
            {
                if (nameOfRecArray[k] == search)
                {
                    Console.WriteLine(nameOfRecipe + "\n" + nameOfIngArray[k] + "\n" + quantityOfRecArray[k] + "\n" + unitOfMesurArray[k]);
                }
            }

            for(int n = 0;n < stepsArray.Count; n++)
            {
                Console.WriteLine("steps " + n + "\n" + stepsArray[n]);
            }

            return search;
        }



        //method for scaling the recipe to disired size
        public static void scaling()
        {
           
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            
            Console.WriteLine("Enter 1 is you would like to scale the quanity to half: " + "\n" +
                              "Enter 2 is you would like to scale the quanity to double: " + "\n" +
                              "Enter 3 is you would like to scale the quanity to triple: " + "\n");
            scaleValue = Convert.ToInt32(Console.ReadLine());

            if(scaleValue == 1)
            {
                for (int i = 0; i < nameOfIngArray.Count; i++)
                {
                    List<double>quantityOfRecArray1 = new List<double>(quantityOfRecArray.Count);
                    quantityOfRecArray1[i] = Convert.ToDouble(quantityOfRecArray[i]);
                    quantityOfRecArray1[i] *= 0.5;
                    Console.WriteLine(nameOfRecipe + "\n" + nameOfIngArray[i] + "\n" + quantityOfRecArray1[i] + "\n" + unitOfMesurArray[i]);
                }
                for (int n = 0; n < stepsArray.Count; n++)
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


        //method to reset the values
        public static void reset()
        {
            string pick;

            Console.WriteLine("Do you want to reset? ");
            pick = Console.ReadLine();

            if(pick == "yes")
            {
                display();

            }

            else
            {
                Console.WriteLine("Thanks for using the app");
            }
        }


    }

    internal class pritave
    {
    }
}
 
  