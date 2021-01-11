using System;
using DotNetTraining.SwitchExpressionsDemo;

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

        }
    }
}
