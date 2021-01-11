using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultInterfaceMethods.Interfaces
{
    /// <summary>
    /// C# 8.0, we can add the default method to the interface without breaking existing implementation.
    /// </summary>
    interface IDefaultMethodInterface
    {
        void MustImpMethod();

        /// <summary>
        /// default method
        /// </summary>
        public void DefaultMethod()
        {
            Console.WriteLine("This is from DefaultMethod");
        }
    }
}
