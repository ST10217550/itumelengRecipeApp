using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itumelengRecipeApp
{
    internal class Clear
    {
        private static String[] nameOfIngArray;
        private static int[] quantityOfRecArray;
        private static String[] unitOfMesurArray;
        private static String[] stepsArray;


        //method to clear the data
        public static void clear()
        {
            nameOfIngArray= null;
            quantityOfRecArray= null;
            unitOfMesurArray= null;
            stepsArray= null;
        }

    }
}
