using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class MyRecipe
    {
        public static int numLemons;
        public static int numSugar;
        public static int numIceCubes;
        public static double pricePerCup;

        public MyRecipe()
        {
            numLemons = 0;
            numSugar = 0;
            numIceCubes = 0;
            pricePerCup = 0;
        }

        public void recipeMenu()
        {
            try
            {
                Console.WriteLine("Type number to navigate. \n'1' - View current recipe \n'2' - Set or change recipe");
                int recipeNav = Int32.Parse(Console.ReadLine());
                switch (recipeNav)
                {
                    case 1:
                        getMyRecipe();
                        break;
                    case 2:
                        setMyRecipe();
                        break;
                    default:
                        recipeMenu();
                        break;
                }
            }
            catch
            {
                recipeMenu();
            }
        }

        public void getMyRecipe()
        {
            if (numLemons == 0 && numSugar == 0 && numIceCubes == 0)
            {
                Console.Clear();
                Console.WriteLine("You have not set a recipe yet.");
                goBackToUI();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Below is your current recipe \n \nLemons - " + numLemons + "\nSugar - " + numSugar + "\nIce Cubes - " + numIceCubes + "\nCup Price - " + pricePerCup);
                goBackToUI();
            }
        }

        public void setMyRecipe()
        {
            int lemonRecipe = getLemonRecipe();
            Console.WriteLine("You have set " + lemonRecipe + " lemons per pitcher");
            int sugarRecipe = getSugarRecipe();
            Console.WriteLine("You have set " + sugarRecipe + " sugar packets per pitcher");
            int IceCubeRecipe = getIceCubeRecipe();
            Console.WriteLine("You have set " + IceCubeRecipe + " ice cubes per pitcher");
            double recipePrice = getRecipePrice();
            Console.WriteLine("You have set price per cup at $" + recipePrice);
            goBackToUI();
        }

        public int getLemonRecipe()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("How many lemons do you want in your recipe?");
                int setLemons = Int32.Parse(Console.ReadLine());
                numLemons = setLemons;
                return numLemons;
            }
            catch
            {
                getLemonRecipe();
                return numLemons;
            }
        }

        public int getSugarRecipe()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("How many packets of sugar do you want in your recipe?");
                int setSugar = Int32.Parse(Console.ReadLine());
                numSugar = setSugar;
                return numSugar;
            }
            catch
            {
                getSugarRecipe();
                return numSugar;
            }
        }

        public int getIceCubeRecipe()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("How many ice cubes do you want in your recipe?");
                int setIceCubes = Int32.Parse(Console.ReadLine());
                numIceCubes = setIceCubes;
                return numIceCubes;
            }
            catch
            {
                getIceCubeRecipe();
                return numIceCubes;
            }
        }

        public double getRecipePrice()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("What do you want the price of each cup to be?");
                double setPricePerCup = Convert.ToDouble(Console.ReadLine());
                pricePerCup = setPricePerCup;
                return pricePerCup;
            }
            catch
            {
                getRecipePrice();
                return pricePerCup;
            }
        }


        public void goBackToUI()
        {
            try
            {
                Console.WriteLine("Type '0' to go back to UI");
                int goback = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (goback)
                {
                    case 0:
                        break;
                    default:
                        setMyRecipe();
                        break;
                }
            }
            catch
            {
                goBackToUI();
            }
        }
    }
}
