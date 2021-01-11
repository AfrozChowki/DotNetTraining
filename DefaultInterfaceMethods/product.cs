using System;
using System.Collections.Generic;
using System.Text;
using DefaultInterfaceMethods.Interfaces;

namespace DefaultInterfaceMethods
{
    class Product : IDefaultMethodInterface
    {
        public void MustImpMethod()
        {
            Console.WriteLine("This is from product class");
        }
    }
}
