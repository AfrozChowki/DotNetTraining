using System;
using DefaultInterfaceMethods.Interfaces;

namespace DefaultInterfaceMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            IDefaultMethodInterface f1 = new Product();
            f1.MustImpMethod();
            //calling default method of interface
            f1.DefaultMethod();

            Console.ReadLine();
        }
    }
}
