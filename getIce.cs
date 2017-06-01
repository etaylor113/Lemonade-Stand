using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class getIce
    {
        public int getStoresIce()
        {
            Console.WriteLine("ice is 5 cents a cube. How many would you like to buy? \nType number for quantity.");
            int iceQuantity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You have purchased " + iceQuantity + " cubes of ice.");
            return iceQuantity;
        }

    }
}
