﻿using System;
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
            try
            {
                Console.WriteLine("Welcome to lemonade stand. You will start off with $20 in your piggy bank. If at any point you run out of money, you can declare bankrupcy and quit the game. \nType 'start' to begin playing.");
                string startGame = Console.ReadLine();
                Console.Clear();
                if (startGame == "start")
                {

                    Game game = new Game();
                    game.startgame();
                }
                else
                {
                    Console.WriteLine("Invalid command entered. Try again.");
                    StartGame();
                }
            }
            catch
            {
                StartGame();
            }
        }
    }
}
