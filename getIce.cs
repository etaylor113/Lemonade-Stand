using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class getIce
    {
        public void getStoresIce()
        {


            double iceCubePrice = .05;

            Console.WriteLine("Ice cubes are five cents a piece. How many would you like to buy? \nType number for quantity.");
            int iceCubeQuantity = Int32.Parse(Console.ReadLine());
            double total = iceCubeQuantity * iceCubePrice;
            if (total < PiggyBank.playerMoney)
            {
                Console.WriteLine("You have purchased " + iceCubeQuantity + " ice cubes for $" + total);
                PiggyBank.playerMoney -= total;
                Inventory.totalIceCubes += iceCubeQuantity;

            }
            else
            {
                Console.WriteLine("Insufficent funds.");
                Console.Read();
                Console.Clear();

            }
            Console.Clear();
        }

    }
}
