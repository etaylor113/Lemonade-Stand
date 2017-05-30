using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class StoreItems
    {

        public int cupStoreItems()
        {
            Console.WriteLine("Cups are one cent a piece. How many would you like to buy? \nType number for quantity.");
            int cupQuantity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You have purchased " + cupQuantity + " cups." );

            return cupQuantity;
        }

        public int lemonStoreItems()
        {
            Console.WriteLine("Lemons are 85 cents a piece. How many would you like to buy? \nType number for quantity.");
            int lemonQuantity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You have purchased " + lemonQuantity + " lemons.");
            return lemonQuantity;
        }


        public int sugarStoreItems()
        {

            Console.WriteLine("Sugar is 70 cents a bag. How many would you like to buy? \nType number for quantity.");
            int sugarQuantity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You have purchased " + sugarQuantity + " bags of sugar.");
            return sugarQuantity;
        }




    }
}
