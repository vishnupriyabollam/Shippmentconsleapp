using System;
using fedexlibrary.cs;
using Shipperorderlib;

namespace FedexSystemConsole.cs
{
    class Program 
    {
        static void Main(string[] args)
        {
           
            Driver d = new Driver();
            d.Login();
            Order o = new Order();
            o.Orders();

        }
    
    }
    
}
