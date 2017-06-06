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

        static public int dayCount = 1;

        public Day()
        {
            dayCount = 0;
        }
        public int gotoNextDay()
        {
            try
            {               
                Console.WriteLine("Type '1' to go to UI, or type '2' to continue on to the next day. \nBe sure you have purchased items from the store and set your recipe before continuing!");
                int nextDayChoice = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (nextDayChoice)
                {
                    case 1:
                        dayCount += 0;                       
                        return dayCount;
                    case 2:                    
                        getWeather();
                        getCustomers();
                        dayCount += 1;
                        return dayCount;
                    default:
                        return gotoNextDay();
                }
            }
            catch
            {
                Console.Clear();
                gotoNextDay();
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
