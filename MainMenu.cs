using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class MainMenu
    {
        public void StartGame()
        {
            PlayerUI playermenu = new PlayerUI();

            Console.WriteLine("Welcome to lemonade stand. Type 'start' to begin playing.");
            string startGame = Console.ReadLine();
            if (startGame == "start")
            {
                playermenu.PlayersUI();
            }


        }


    }
}
