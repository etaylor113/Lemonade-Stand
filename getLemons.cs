using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class getLemons
    {
        public int getStoresLemons()
        {
            Console.WriteLine("Lemons are 85 cents a piece. How many would you like to buy? \nType number for quantity.");
            int lemonQuantity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You have purchased " + lemonQuantity + " lemons");
            return lemonQuantity;
        }


    }
}
