using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class goBankrupt
    {

        public void declarebankrupcy()
        {
            try
            {
                int navigate;
                MainMenu travelMainMenu = new MainMenu();
                Console.WriteLine("You've declared bankrupcy! Would you like to play again and beat your score? \nType number to navigate \n'1' - yes \n'2'- no");
                navigate = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (navigate)
                {
                    case 1:
                        travelMainMenu.StartGame();
                        break;
                    case 2:
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Not a valid command. Try again.");
                        declarebankrupcy();
                        break;
                }
            }
            catch
            {
                declarebankrupcy();
            } 
        }
  
    }
}
