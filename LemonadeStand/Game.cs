using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    class Game
    {
       
        public Game()
        {
            Weather weather = new Weather();
            weather.GetForcast();
            weather.GetTempreture();
            Console.ReadLine();

            PotentialCustomer potentialCustomer = new PotentialCustomer();
            potentialCustomer.displayPrice();
            potentialCustomer.getItemPrice();
            Console.ReadLine();


        }
    }
}
