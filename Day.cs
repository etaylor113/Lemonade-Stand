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


        public bool gotoNextDay()
        {
            bool goNext;
            Console.WriteLine("Type '1' to go to UI, or type '2' to continue on to the next day.");
            int nextDayChoice = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (nextDayChoice)
            {
                case 1:
                    goNext = true;
                    return goNext;
                case 2:
                    goNext = false;
                    return goNext;
                default:
                    return gotoNextDay();

            }  
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
