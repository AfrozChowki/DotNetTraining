using System;
using System.Collections.Generic;
using System.Text;

namespace DisoposableDemo
{
    class Program2
    {
        public static void Main(string[] args )
        {
            CreateConnectionAndMemory(50);
            //GC.Collect(0);
            //GC.WaitForPendingFinalizers();
            //GC.Collect(2);
           
            Console.WriteLine($"Total Allocated {ConnectionAndMemory.TotalAllocated}," +
                              $"Total DeAllocated{ConnectionAndMemory.TotalFreed}");

        }
        private static void CreateConnectionAndMemory(int quantity)
        {
            Random random = new Random();
            for(int i=0;i<quantity;i++)
            {
                int chunkSize = random.Next(4096);
                Console.WriteLine(chunkSize);
                using ConnectionAndMemory connectionAndMemory = new ConnectionAndMemory(chunkSize);
                connectionAndMemory.DoWork();

            }
        }
    }
}
