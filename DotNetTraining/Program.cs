using System;
using System.Threading.Tasks;
using DotNetTraining.IndicesAndRangesDemo;
using DotNetTraining.UsingDeclarationDemo;

namespace DotNetTraining
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("\n\t NullCoalescing Demo\n\n");
            var nc = new NullCoalescing();
            nc.NullCoalescingExample();
            var indexAndRange = new IndicesAndRanges();
            indexAndRange.IndexAndRange();

            Company company = new Company();

            Console.WriteLine("\n\t NullCoalescing Demo Ends Here\n\n");
            Console.WriteLine("\n\t Press Any Key....Proceed to Next Demo\n\n");
            Console.ReadLine();
            Console.ReadLine();

            //Lets demonstrate Using declaration
            Console.WriteLine("\n\n Showing using declaration \n\n");
            try
            {
                //creating new resource

                using var resource = new UsingDeclaration();
                Console.WriteLine("Using resource1...");

                if (true)
                {
                    using var resource2 = new UsingDeclaration();
                    Console.WriteLine("Using resource2...");
                }

                // Asynchronous disposable demo
                await using var resource3 = new UsingDeclaration();
                Console.WriteLine("Using resource3...");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            Console.WriteLine("\n\n \tDemonstration of Switch Expression Functionality\n\n");
            Console.WriteLine("\n\t Press Any Key....Proceed to Next Demo\n\n");
            Console.ReadLine();
        }
    }
}
