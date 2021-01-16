using System;
using ReadOnlyDemo;

namespace ReadOnlyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main method 
           
                Customer a = new Customer("Sumit", "Mobile Phone", 2398);
                Console.WriteLine("Customer name: " + a.Name);
                Console.WriteLine("Product: " + a.Product);
                Console.WriteLine("Price: " + a.Price);
            
        }
    }
}
