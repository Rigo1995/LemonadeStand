using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public void GetForcast()
        {
            Random rnd = new Random();

            string[] Forcast = { "Rain", "Overcast", "Sunny", "Foggy", "Windy" };
            int index = rnd.Next(0, 6);

            Console.WriteLine("The current forcast calls for {0,6} conditions", Forcast[index]);
        
        }

        public void GetTempreture()
        {
            Random rnd = new Random();

            int[] Tempreture = { 100, 95, 85, 80, 50, 45 };
            int index = rnd.Next(0, 6);

            Console.WriteLine("With a high tempreture of: {0}", Tempreture[index]);

        }

     
    }
}
