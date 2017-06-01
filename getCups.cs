using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class getCups
    {
        public int getStoresCups()
        {
            Console.WriteLine("Cups are one cent a piece. How many would you like to buy? \nType number for quantity.");
            int cupQuantity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You have purchased " + cupQuantity + " cups.");
            return cupQuantity;
        }

    }
}
