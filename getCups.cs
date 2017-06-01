using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class getCups
    {

        public void getStoresCups()
        {

            double cupPrice = .01;

            Console.WriteLine("Cups are one cent a piece. How many would you like to buy? \nType number for quantity.");
            int cupQuantity = Int32.Parse(Console.ReadLine());
            double total = cupQuantity * cupPrice;
            if (total < PiggyBank.playerMoney)
            {
                Console.WriteLine("You have purchased " + cupQuantity + " cups for $" + total + "\nType '0' to return to UI.");
                int returnUI = Int32.Parse(Console.ReadLine());
                PiggyBank.playerMoney -= total;
                Inventory.totalCups += cupQuantity;

                switch (returnUI)
                {
                    case 0:

                        break;
                    default:
                        getStoresCups();
                        break;

                }

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
