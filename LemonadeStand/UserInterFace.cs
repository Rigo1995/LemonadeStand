using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterFace
    {
        public static void ItemsForSale(Store store)
        {
            Console.WriteLine("you have $20 to start your lemonade stand!");
            Console.WriteLine("0 - Paper Cups cost " + store.paper_Cup.price);
            Console.WriteLine("1 - Lemons cost "+ store.lemons.price);
            Console.WriteLine("2 - Cups Of Sugar " + store.sugar.price);
            Console.WriteLine("3 - Ice Cubes " +store.ice_Cubes.price);
            Console.WriteLine("4 - <exit>");
           
        }

         

       
        
    }



}
