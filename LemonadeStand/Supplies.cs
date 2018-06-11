using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class PotentialCustomer
    {
       

        public void getItemPrice()
        {
            Console.WriteLine("you have $20 to start your lemonade stand!");
            Console.WriteLine("what would you like to purchace? \n");
            Console.WriteLine("0 - 25 Paper Cups      $.86"); 
            Console.WriteLine("1 - 10 Lemons          $.70");
            Console.WriteLine("2 - 8 Cups Of Sugar    $.70");
            Console.WriteLine("3 - 100 Ice Cubes      $.92");
            Console.WriteLine("4 - <exit>");
            //set dictionary

            
            List<string> items = new List<string>();
              
                    items.Add("Paper Cups");
                    items[0] = "PaperCups";
                    items.Add("Lemons");
                    items[1] = "Lemons";
                    items.Add("Cups Of Sugar");
                    items[2] = "Cups Of Sugar";
                    items.Add("Ice Cube");
                    items[3] = "Ice Cube";
                    items.Add("<exit>");
                    items[4] = "<exit>";
            
            
        }

        public void displayPrice()
        {

        }











    }

}




















































    
  
   

































































        

    

        