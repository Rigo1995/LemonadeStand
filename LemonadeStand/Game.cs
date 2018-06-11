using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    public class Game
    {
       
        public void RunGame()
        {
            Weather weather = new Weather();
            weather.GetForcast();
            weather.GetTempreture();
            Console.ReadLine();

            Store store = new Store();
            store.ShowPriceOfItems();
            Console.ReadLine();

            



        }
    }
}
