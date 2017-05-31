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
            PlayerUI travelUI = new PlayerUI();

            Console.WriteLine("Welcome to the store! Would you like to buy cups, lemons, or sugar? \nType number to navigate \n'0' - return to main screen \n'1' - cups \n'2' - lemons \n'3' - sugar");
            int productChoice = Int32.Parse(Console.ReadLine());
            switch (productChoice)
            {
                case 0:
                  travelUI.getItems();
                    break; 
                case 1:
                    gotoStore.cupStoreItems();
                    getItems();
                    break;
                case 2:
                    gotoStore.lemonStoreItems();
                    getItems();
                    break;
                case 3:
                    gotoStore.sugarStoreItems(travelUI.travelBank);
                    getItems();
                    break;
                default:
                    Console.WriteLine("Please enter a valid product name.");
                    getItems();
                    break;
            }
            
        }



    }
}
