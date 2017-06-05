using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class PiggyBank
    {
        public static double playerMoney = 40.00;
        public PiggyBank()
        {
            playerMoney = 40.00;
            
        }

        
        public void DisplayPlayerMoney()
        {
            try
            {
                Console.WriteLine("Your current balance is $" + playerMoney + "\nType '0' to go back.");
                int goBackToPlayerUI = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (goBackToPlayerUI)
                {
                    case 0:

                        break;
                    default:
                        DisplayPlayerMoney();
                        break;
                }
            }

            catch
            {
                Console.Clear();
                DisplayPlayerMoney();
            }
        }
    }
}
