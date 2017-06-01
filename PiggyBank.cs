using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class PiggyBank
    {
        public double playerMoney;
        public PiggyBank()
        {
            playerMoney = 20.00;
        }
        public void DisplayPlayerMoney()
        {
            Console.WriteLine("Your current balance is $" + playerMoney);
            Console.Read();
        }


    }
}
