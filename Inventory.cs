using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Inventory
    {
        public static int totalCups;
        public static int totalLemons;
        public static int totalSugar;
        public static int totalIceCubes;

        public Inventory()
        {
            totalCups = 0;
            totalLemons = 0;
            totalSugar = 0;
            totalIceCubes = 0;
        }

        public void getInventory()
        {
            try
            {
                Console.WriteLine("Welcome to your inventory!");
                Console.WriteLine("Total cups - " + totalCups + "\nTotal Lemons - " + totalLemons + "\nTotal Sugar - " + totalSugar + "\nTotal Ice Cubes - " + totalIceCubes + "\nType '0' to go back.");
                int goBackToPlayerUI = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (goBackToPlayerUI)
                {
                    case 0:

                        break;
                    default:
                        getInventory();
                        break;
                }
            }
            catch
            {
                Console.Clear();
                getInventory();
            }
        }
    }
}
