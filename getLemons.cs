using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class getLemons
    {
        public void getStoresLemons()
        {
            double lemonPrice = .85;

            Console.WriteLine("Lemons are 85 cents a piece. How many would you like to buy? \nType number for quantity.");
            int lemonQuantity = Int32.Parse(Console.ReadLine());
            double total = lemonQuantity * lemonPrice;
            if (total < PiggyBank.playerMoney)
            {
                Console.WriteLine("You have purchased " + lemonQuantity + " lemons for $" + total + "\nType '0' to return to UI");
                int returnUI = Int32.Parse(Console.ReadLine());
                PiggyBank.playerMoney -= total;
                Inventory.totalLemons += lemonQuantity;
                switch (returnUI)
                {
                    case 0:
                        break;
                    default:
                        getStoresLemons();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Insufficent funds.");
                Console.Read();
                getStoresLemons();

            }
            Console.Clear();
        }
    }
}

