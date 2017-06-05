using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Weather
    {
        static public int todaysWeather;
        static public int todaysTemperature;
        public int getRandomWeather()
        {
            
            Random random = new Random();
            todaysWeather = random.Next(1, 5);

            switch (todaysWeather)
            {
                case 1:
                    int todaysWeather;
                    todaysWeather = 1;
                    Console.WriteLine("The forecast calls for sunny skies and hot weather.");
                    return todaysWeather;
                case 2:
                    todaysWeather = 2;
                    Console.WriteLine("The forecast calls for clear skies and warm weather.");
                    return todaysWeather;
                case 3:
                    todaysWeather = 3;
                    Console.WriteLine("The forecast calls for cloudy skies and cool weather.");
                    return todaysWeather;
                case 4:
                    todaysWeather = 4;
                    Console.WriteLine("The forecast calls for rain and cool weather.");
                    return todaysWeather;
                default:
                    Console.WriteLine("An error has occurred.");
                    Console.Read();
                    getRandomWeather();
                    return getRandomWeather();
            }
        }

        public int getTemperature()
        {
            Random random = new Random();
            int todaysWeather= getRandomWeather();
            switch (todaysWeather)
            {
                case 1:
                    int todaysTemperature;
                    todaysTemperature = random.Next(60, 101);
                    Console.WriteLine("The temperature today is " + todaysTemperature);
                   
                    return todaysTemperature;
                case 2:
                    todaysTemperature = random.Next(60, 81);
                    Console.WriteLine("The temperature today is " + todaysTemperature);
                   
                    return todaysTemperature;
                case 3:
                    todaysTemperature = random.Next(50, 71);
                    Console.WriteLine("The temperature today is " + todaysTemperature);
                   
                    return todaysTemperature;
                case 4:
                    todaysTemperature = random.Next(40, 61);
                    Console.WriteLine("The temperature today is " + todaysTemperature);
                    
                    return todaysTemperature;
                default:
                    return getTemperature();

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
