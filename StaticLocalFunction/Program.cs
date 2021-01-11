using System;

namespace StaticLocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("static local function  = " + Program.Add());

            Console.ReadLine();
        }

        /// <summary>
        /// implementation of Static modifier to local function
        /// </summary>
        /// <returns></returns>
        public static int Add()
        {
            int x = 10;
            int y = 20;
            return Sum(x, y);

            //
            //Below line return error : A static local function cannot contain a reference to y.
            //

            //  static int localfunction() => y;

            //You can now add the static modifier to local functions
            //to ensure that local function doesn't capture (reference) any variables
            //from the enclosing scope. 
            static int Sum(int left, int right) => left + right;
        }

    }
}
