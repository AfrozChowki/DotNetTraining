using System;

namespace SwitchExpressionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a bank of Private Type

            var bank1 = new Bank(Type.Private);
            Console.WriteLine(bank1.ToString());
            Console.WriteLine();

            // Creating a bank of Commercial Type
            var bank2 = new Bank(Type.Commercial);
            Console.WriteLine(bank2.ToString());
            Console.WriteLine();

            // Creating a bank of Public Type
            var bank3 = new Bank(Type.Public);
            Console.WriteLine(bank3.ToString());
            Console.ReadLine();
        }
    }
}
