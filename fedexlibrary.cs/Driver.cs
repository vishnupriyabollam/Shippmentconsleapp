using System;
using System.Collections.Generic;
using System.Text;

namespace fedexlibrary.cs
{
    public class Driver : Front
    {
        public string Name { get; set; }
        public string Password { get; set ; }
        public void Login()
        {
            Console.WriteLine("enter the credentials");
            Console.WriteLine("enter the Name");
            Name = Console.ReadLine();
            Console.WriteLine("enter the Password");
            Password = Console.ReadLine();
        }
    }
}
