using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    public class Game
    {
        Store store;
        public Game()
        {
            store = new Store();
        }
       
        public void RunGame()
        {
            Weather weather = new Weather();
            weather.GetForcast();
            weather.GetTempreture();
            Console.ReadLine();

            
            UserInterFace.ItemsForSale(store);
            Console.ReadLine();

            //inventory.GetNumberOfLemons();


        }
    }
}
