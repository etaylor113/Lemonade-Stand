using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class PlayerUI
    {
        public PiggyBank travelBank = new PiggyBank();
        public void getItems()
        {

            StoreMenu travelStore = new StoreMenu();
            PlayerItems travelItems = new PlayerItems();
            Weather travelweather = new Weather();
            goBankrupt travelExit = new goBankrupt();
            

            int navigate;
            Console.WriteLine("\nType number to navigate. \n'1' - store \n'2' - current inventory \n'3' - weather forecast \n'4' - declare bankrupcy");
            navigate = Int32.Parse(Console.ReadLine());
            switch(navigate)
            {
                case 1:
                   travelStore.getItems();
                    break;
                case 2:
                    travelItems.getItems();
                    break;
                case 3:
                    travelweather.getTemperature();
                    break;
                case 4:
                    travelExit.declarebankrupcy();
                    break;
                default:
                    Console.WriteLine("Not a valid command.");
                    getItems();
                    break;

            }

        }

    }
}
