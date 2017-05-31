using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class PlayerUI
    {

        public void PlayersUI()
        {

            StoreMenu travelStore = new StoreMenu();
            PlayerItems travelItems = new PlayerItems();
            Bank travelBank = new Bank();
            Weather travelweather = new Weather();
            goBankrupt travelExit = new goBankrupt();


            int navigate;
            Console.WriteLine("\nType number to navigate. \n'1' - store \n'2' - current inventory \n'3' - piggy bank \n'4' - weather forecast \n'5' - declare bankrupcy");
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
                    travelBank.playerbank();
                    break;
                case 4:
                    travelweather.getTemperature();
                    break;
                case 5:
                    travelExit.declarebankrupcy();
                    break;
                default:
                    Console.WriteLine("Not a valid command.");
                    PlayersUI();
                    break;

            }

        }

    }
}
