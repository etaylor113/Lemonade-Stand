using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class StoreMenu
    {

        public void getItems()
        {
            StoreItems gotoStore = new StoreItems();

            Console.WriteLine("Welcome to the store! Would you like to buy cups, lemons, or sugar? \nType 'cups', 'lemons', or 'sugar'");
            string productChoice = Console.ReadLine();
            switch (productChoice)
            {
                case "cups":
                    gotoStore.cupStoreItems();
                    break;
                case "sugar":
                    gotoStore.sugarStoreItems();
                    break;
                case "lemons":
                    gotoStore.lemonStoreItems();
                    break;
                default:
                    Console.WriteLine("Please enter a valid product name.");
                    getItems();
                    break;
            }
            
        }



    }
}
