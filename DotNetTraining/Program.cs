using System;
using System.Threading.Tasks;
using DotNetTraining.SwitchExpressionsDemo;
using DotNetTraining.UsingDeclarationDemo;

namespace DotNetTraining
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nc = new NullCoalescing();
            nc.NullCoalescingExample();
            var indexAndRange = new IndicesAndRanges();
            indexAndRange.IndexAndRange();


            //Here We will see demonstration of Switch Expressions
            Console.WriteLine("\n\nDemonstration of Switch Expression Functionality\n\n");
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

            //Lets demonstrate Using declaration
            Console.WriteLine("\n\n Showing using declaration \n\n");
            try
            {
                //creating new resource

                using var resource = new UsingDeclaration();
                Console.WriteLine("Using resource1...");

                var flag = true;
                if (flag)
                {
                    using var resource2 = new UsingDeclaration();
                    Console.WriteLine("Using resource2...");

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            // Asynchronous stream demo
            GenerateSequenceAsync().GetAwaiter().GetResult();

        }

        public static async System.Collections.Generic.IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }

        public static async Task GenerateSequenceAsync()
        {
            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
            }
        }

    }
}
