using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
   public class MyRecipe
    {
        public int numLemons;
        public int numSugar;
        public int numIceCubes;
        public double pricePerCup;

        public MyRecipe()
        {
            numLemons = 0;
            numSugar = 0;
            numIceCubes = 0;
            pricePerCup = 1.00;
        }





        public void getMyRecipe()
        {
            getLemonRecipe();
            getSugarRecipe();
            getIceCubeRecipe();
            getRecipePrice();
        }

        public int getLemonRecipe()
        {
            Console.WriteLine("How many lemons do you want in your recipe?");
            int setLemons = Int32.Parse(Console.ReadLine());
            numLemons = setLemons;
            return numLemons;
        }

        public int getSugarRecipe()
        {
            Console.WriteLine("How many packets of sugar do you want in your recipe?");
            int setSugar = Int32.Parse(Console.ReadLine());
            numSugar = setSugar;
            return numSugar;
        }

        public int getIceCubeRecipe()
        {
            Console.WriteLine("How many ice cubes do you want in your recipe?");
            int setIceCubes = Int32.Parse(Console.ReadLine());
            numIceCubes = setIceCubes;
            return numIceCubes;
        }

        public double getRecipePrice()
        {
            Console.WriteLine("What do you want the price of each cup to be?");
            double setPricePerCup = Int32.Parse(Console.ReadLine());
            pricePerCup = setPricePerCup;
            return pricePerCup;
        }

    }
}
