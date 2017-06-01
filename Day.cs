using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{


    class Day
    {
        Weather weather = new Weather();
        Customers customers = new Customers();


        public void gotoNextDay()
        {
            Console.WriteLine("Its the next day!");
            Console.Read();
        }



        public void getWeather()
        {
            weather.getTemperature();
        }

        public void getCustomers()
        {
            customers.getCustomers();
        }





    }
}
