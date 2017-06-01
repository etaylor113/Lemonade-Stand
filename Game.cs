using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {
        Player player = new Player();
        Day day = new Day();
        Store store = new Store();
        goBankrupt bankrupt = new goBankrupt();
        public void startgame()
        {
            while (day.gotoNextDay() == true)
            {
                int personNav;
                Console.WriteLine("What would you like to do? Type number to navigate. \n'1' - Go to inventory \n'2' - Go to wallet \n'3' - Go shopping \n'4' - Check forecast \n'5' - Go to next day \n'6' - File for bankrupcy (quit game)");
                personNav = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (personNav)
                {
                    case 1:
                        player.getPlayerInventory();
                        break;
                    case 2:
                        player.getPlayerWallet();
                        break;
                    case 3:
                        store.gotoStore();
                        break;
                    case 4:
                        day.getWeather();
                        break;
                    case 5:
                        day.gotoNextDay();
                        break;
                    case 6:
                        bankrupt.declarebankrupcy();
                        break;
                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        break;


                }
            }
        }


    }
}
