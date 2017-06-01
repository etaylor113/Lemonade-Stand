using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        getCups cups = new getCups();
        getLemons lemon = new getLemons();
        getSugar sugar = new getSugar();
        getIce ice = new getIce();


        public void gotoStore()
        {
            Console.WriteLine("Welcome to the store! \nHere you can shop for cups, lemons, sugar, and ice cubes. \nType number to buy items or '0' to go back.\n \nYour current budget is $" + PiggyBank.playerMoney + "\n \n'1' - Cups($0.01) \n'2' - Lemons($0.85) \n'3' - Sugar($0.70) \n'4' - Ice Cubes($0.05)");
            int selectedItem = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (selectedItem)
            {
                case 0:
                    goBackToUI();
                    break;
                case 1:
                    cups.getStoresCups();
                    break;
                case 2:
                    lemon.getStoresLemons();
                    break;
                case 3:
                    sugar.getStoresSugar();
                    break;
                case 4:
                    ice.getStoresIce();
                    break;
                default:
                    Console.WriteLine("Please enter a valid command.");
                    gotoStore();
                    break;
            }
        }

             private void goBackToUI()
        {
            Game game = new Game();
            game.startgame();
        }

    


    }
}
