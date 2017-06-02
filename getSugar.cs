using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class getSugar
    {
        public void getStoresSugar()
        {

            double sugarPrice = .70;

            Console.WriteLine("Sugar is 70 cents a packet. How many would you like to buy? \nType number for quantity.");
            int sugarQuantity = Int32.Parse(Console.ReadLine());
            double total = sugarQuantity * sugarPrice;
            if (total < PiggyBank.playerMoney)
            {
                Console.WriteLine("You have purchased " + sugarQuantity + " packets of sugar for $" + total + "\nType '0' to return to UI.");
                int returnUI = Int32.Parse(Console.ReadLine());
                PiggyBank.playerMoney -= total;
                Inventory.totalSugar += sugarQuantity;
                switch (returnUI)
                {
                    case 0:
                        break;
                    default:
                        getStoresSugar();
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
