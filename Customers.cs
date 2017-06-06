using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Customers
    {
        Random random = new Random();
        public int customerLemonPref;
        public int customerSugarPref;
        public int customerIceCubePref;
        public int customerPricePref;
        public int todaysWeather;
        public int todaysTemperature;
        public double todaysProfit;
        public int cupCounter;

        public Customers()
        {
            customerLemonPref = 0;
            customerSugarPref = 0;
            customerIceCubePref = 0;
            customerPricePref = 0;
            todaysProfit = 0;
            cupCounter = 15;
        }

        public void getCustomers()
        {
            List<List<int>> customers = new List<List<int>>();
            int i = 0;
            int customerCount = 1;
            int weatherType = 0;
            int todaysWeather = Weather.todaysWeather;

            switch (todaysWeather)
            {
                case 1:
                    weatherType += 300;
                    break;
                case 2:
                    weatherType += 250;
                    break;
                case 3:
                    weatherType += 100;
                    break;
                case 4:
                    weatherType += 50;
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }

            while (i < weatherType)
            {
                if (Inventory.totalCups != 0 || Inventory.totalLemons < MyRecipe.numLemons || Inventory.totalSugar < MyRecipe.numSugar || Inventory.totalIceCubes != 0 || MyRecipe.numLemons != 0 || MyRecipe.numSugar != 0 || MyRecipe.pricePerCup != 0 || MyRecipe.numIceCubes != 0)
                {
                    customers.Add(new List<int>());
                    customerLemonPref = getCustomerLemonPref();
                    customerSugarPref = getCustomerSugarPref();
                    customerIceCubePref = getCustomerIceCubePref();
                    customerPricePref = getCustomerPricePref();

                    Console.WriteLine("\n---------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("\nCUSTOMER #" + customerCount);
                    customers[0].Add(customerLemonPref);
                    Console.WriteLine("customer Lemon preference is " + customerLemonPref);
                    customers[0].Add(customerSugarPref);
                    Console.WriteLine("customer Sugar preference is " + customerSugarPref);
                    customers[0].Add(customerIceCubePref);
                    Console.WriteLine("customer Ice preference is " + customerIceCubePref);
                    customers[0].Add(customerPricePref);
                    Console.WriteLine("customer Price preference is " + customerPricePref);

                    if (cupCounter == 0)
                    {
                        cupCounter += 15;
                        Inventory.totalCups -= 1;
                        Inventory.totalLemons -= MyRecipe.numLemons;
                        Inventory.totalSugar -= MyRecipe.numSugar;
                        Inventory.totalIceCubes -= MyRecipe.numIceCubes;
                    }
                    else if (customerLemonPref == MyRecipe.numLemons && customerSugarPref == MyRecipe.numSugar && customerIceCubePref == MyRecipe.numIceCubes)
                    {
                        todaysProfit += MyRecipe.pricePerCup;
                        cupCounter -= 1;                        
                        Console.Write("\n--SOLD--\nYou've made $" + todaysProfit + " today.\n\n");
                        //Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.Write("\n--NO SALE--\nYou've made $" + todaysProfit + " today.\n\n");
                        //Thread.Sleep(1000);
                    }
                        Console.WriteLine("Cups in pitcher - " + cupCounter);
                        customerCount++;
                        i++;
                }
                else
                {
                    Console.WriteLine("You ran out of supplies!");
                    break;
                }
            }
            PiggyBank.playerMoney += todaysProfit;
            Console.WriteLine("Your current piggy bank amount is $" + PiggyBank.playerMoney);
            goBackToUI();
            }

        public int getCustomerLemonPref()
        {
            int randLemonPref;           
            randLemonPref = random.Next(4, 6);
            return randLemonPref;
        }

        public int getCustomerSugarPref()
        {
            int randSugarPref;
            randSugarPref = random.Next(2, 4);
            return randSugarPref;
        }

        public int getCustomerIceCubePref()
        {
            int randIceCubePref;
            randIceCubePref = random.Next(2, 5);
            return randIceCubePref;
        }

        public int getCustomerPricePref()
        {
            int randPricePref;
            Random random = new Random();
            randPricePref = random.Next(0, 4);
            return randPricePref;
        }

        private void goBackToUI()
        {
            try
            {
                Console.WriteLine("Type '0' to continue.");
                int goBack = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (goBack)
                {
                    case 0:
                        break;
                    default:
                        getCustomers();
                        break;
                }
            }
            catch
            {
                goBackToUI();
            }
        }
    }
}
