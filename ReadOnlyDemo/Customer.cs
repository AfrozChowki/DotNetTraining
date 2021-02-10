using System;

namespace ReadOnlyDemo
{
    public struct Customer
    {
        public string Name { get; }
        public int Price { get; }

        // Readonly member 
        public readonly string Product { get; }

        public Customer(string name, string product, int price)
        {

            this.Name = name;
            this.Product = product;
            this.Price = price;
        }
    }
}
