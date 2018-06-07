using System;
using System.Collections.Generic;
using System.Text;


namespace Shipperorderlib
{
    public class Order
    {
        string startlocation { get; set; } 
        string droplocation { get; set; }
        string couriertype { get; set; }
        public void Orders()
        {
            Console.WriteLine("Enter the courier details");
            Console.WriteLine("enter the start location");
            startlocation = Console.ReadLine();
            Console.WriteLine("enter the drop location");
            droplocation = Console.ReadLine();
            Console.WriteLine("enter the courier type");         
            couriertype = Console.ReadLine();
            if((startlocation=="hyderabad")&&(droplocation=="bangolore"))
            {
                if (couriertype == "gift")
                    Console.WriteLine("the payment need to be pay is 500 rupees");
            }
        }

    }
}
