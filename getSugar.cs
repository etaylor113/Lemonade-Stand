using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class getSugar
    {
        public int getStoresSugar()
        {
            Console.WriteLine("Sugar is 70 cents a bag. How many would you like to buy? \nType number for quantity.");
            int sugarQuantity = Int32.Parse(Console.ReadLine());
            double total = sugarQuantity * .7;
            return sugarQuantity;

        }


    }
}
