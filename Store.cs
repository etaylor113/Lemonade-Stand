using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        getCups cups = new getCups();
        getLemons lemon = new getLemons();
        getSugar sugar = new getSugar();
        getIce ice = new getIce();


        public void gotoStore()
        {
            Console.WriteLine("Welcome to the store! Here you can shop for cups, lemons, sugar, and ice cubes.");
            Console.Read();
            int numCups = cups.getStoresCups();
            int numLemons = lemon.getStoresLemons();
            int numSugar = sugar.getStoresSugar();
            int numIce = ice.getStoresIce();
        }


    }
}
