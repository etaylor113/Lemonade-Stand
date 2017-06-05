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

        public int customerLemonPref;
        public int customerSugarPref;
        public int customerIceCubePref;
        public double customerPricePref;

        public Customers()
        {
            customerLemonPref = 0;
            customerSugarPref = 0;
            customerIceCubePref = 0;
            customerPricePref = 0;

        }

        public void getCustomers()
        {
            Console.WriteLine("customers tab");

            List<List<int>> customers = new List<List<int>>();
            int i = 0;
            int customerCount = 1;

            while (i < 50)
            {           
                customers.Add(new List<int>());
                
                int customerLemonPref = getCustomerLemonPref();
                int customerSugarPref = getCustomerSugarPref();
                int customerIceCubePref = getCustomerIceCubePref();
                int customerPricePref = getCustomerPricePref();
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

                
                    if (customerLemonPref == MyRecipe.numLemons && customerSugarPref == MyRecipe.numSugar && customerIceCubePref == MyRecipe.numIceCubes)
                    {
                        PiggyBank.playerMoney += MyRecipe.pricePerCup;
                        Console.Write("\n--SOLD--\nYour current money is $" + PiggyBank.playerMoney + "\n\n");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.Write("\n--NO SALE--\nYour current money is $" + PiggyBank.playerMoney + "\n\n");
                        Thread.Sleep(1000);
                    }
                        customerCount++;
                        i++;
                    }
            Console.ReadLine();

        }


        public int getCustomerLemonPref()
        {
            int randLemonPref;
            Random random = new Random();
            randLemonPref = random.Next(4, 6);
            return randLemonPref;
        }

        public int getCustomerSugarPref()
        {
            int randSugarPref;
            Random random = new Random();
            randSugarPref = random.Next(2, 4);
            return randSugarPref;
        }


        public int getCustomerIceCubePref()
        {
            int randIceCubePref;
            Random random = new Random();
            randIceCubePref = random.Next(2, 4);
            return randIceCubePref;
        }

        public int getCustomerPricePref()
        {
            int randPricePref;
            Random random = new Random();
            randPricePref = random.Next(0, 4);
            return randPricePref;
        }





    }
}
