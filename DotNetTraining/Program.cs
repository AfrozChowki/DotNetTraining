using System;
using System.Threading.Tasks;
using DotNetTraining.SwitchExpressionsDemo;
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

            Console.WriteLine("\n\t NullCoalescing Demo Ends Here\n\n");
            Console.WriteLine("\n\t Press Any Key....Proceed to Next Demo\n\n");
            Console.ReadLine();

            //Here We will see demonstration of Switch Expressions
            Console.WriteLine("\n\n \tDemonstration of Switch Expression Functionality\n\n");
            //creating new Bank() object
            var bank = new Bank();

            //using static method of simple switch expression
            var bankOpen = AccessBank.AccessBankSimpleSwitch(bank, true);

            //printing result
            Console.WriteLine("Simple \n Bank is Open :" + bankOpen);

            //using static method of tuple switch expression
            (bankOpen) = AccessBank.AccessBankUsingTuple(bank, false);

            //printing result
            Console.WriteLine("Tuple \n Bank is Open :" + bankOpen);

            //using static method of tuple switch expression
            (bankOpen) = AccessBank.AccessBankUsingProperty(bank, true);

            //printing result
            Console.WriteLine("Property \n Bank is Open :" + bankOpen);
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
