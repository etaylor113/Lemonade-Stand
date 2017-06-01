using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Player
    {
       public  Inventory inventory = new Inventory();
       public PiggyBank piggyBank = new PiggyBank();
        public void getPlayerInventory()
        {
            inventory.getInventory();
           
        }
        public void getPlayerWallet()
        {
            piggyBank.DisplayPlayerMoney();
        }


    }
}
