using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu Inititate = new MainMenu();
            Inititate.StartGame();
        }
    }
}





//Single responsibility principle - An example of me using this is in classes getcup, getsugar, getlemons and geticecubes. 

//Open/ closed principle - The way I retrieve my data for customer preferences allows me to easily add on more customers preferences if desired in the future. 
//          The way my user interface is set up, I could very easily add more options for a user to navigate to. 