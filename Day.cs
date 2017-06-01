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
            Console.WriteLine("Type '0' to go to next day.");
            int gotoNextDay = Int32.Parse(Console.ReadLine());
                if (gotoNextDay == 0)
            {
                
                return true;
            }
            else
            {
                return false;
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
