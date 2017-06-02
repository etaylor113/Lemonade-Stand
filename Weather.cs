using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {

        public string getRandomWeather()
        {
            int randweather;
            Random random = new Random();
            randweather = random.Next(1, 5);

            switch (randweather)
            {
                case 1:
                    string todaysWeather;
                    todaysWeather = "sunny";
                    Console.WriteLine("The forecast calls for sunny skies and hot weather.");
                    return todaysWeather;
                case 2:
                    todaysWeather = "clear";
                    Console.WriteLine("The forecast calls for clear skies and warm weather.");
                    return todaysWeather;
                case 3:
                    todaysWeather = "cloudy";
                    Console.WriteLine("The forecast calls for cloudy skies and cool weather.");
                    return todaysWeather;
                case 4:
                    todaysWeather = "rainy";
                    Console.WriteLine("The forecast calls for rain and cool weather.");
                    return todaysWeather;
                default:
                    Console.WriteLine("An error has occurred.");
                    Console.Read();
                    getRandomWeather();
                    return getRandomWeather();
            }
        }

        public void getTemperature()
        {
            Random random = new Random();
            string todaysWeather = getRandomWeather();
            switch (todaysWeather)
            {
                case "sunny":
                    int randtemp;
                    randtemp = random.Next(60, 101);
                    Console.WriteLine("The temperature today is " + randtemp);
                    gobackToUI();
                    break;
                case "clear":
                    randtemp = random.Next(60, 81);
                    Console.WriteLine("The temperature today is " + randtemp);
                    gobackToUI();
                    break;
                case "cloudy":
                    randtemp = random.Next(50, 71);
                    Console.WriteLine("The temperature today is " + randtemp);
                    gobackToUI();
                    break;
                case "rainy":
                    randtemp = random.Next(40, 61);
                    Console.WriteLine("The temperature today is " + randtemp);
                    gobackToUI();
                    break;
                default:
                    getTemperature();
                    break;
            }
        }

        private void gobackToUI()
        {
            Game game = new Game();

            Console.WriteLine("Type '0' to go back.");
            int goBack = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (goBack)
            {
                case 0:
                    game.startgame();
                    break;
                default:
                    gobackToUI();
                    break;
            }

        }


    }
}
