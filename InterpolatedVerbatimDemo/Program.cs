using System;

namespace InterpolatedVerbatimDemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            #region Interpolation
            //Interpolation is used to formatting the string to increase the readability
            var name = "Saitej";
            //string concatenation
            Console.WriteLine("Hello "+name);
            //using placeholders
            Console.WriteLine("Hello {0}",name);
            //using string interpolation
            Console.WriteLine($"Hello {name}");

            #endregion

            #region Verbatim
            //useful to specify the file paths,SQL string and XML strings

            string player = "\narine";
            Console.WriteLine(player);
            string pathActual = "c:\program files\Microsoft.Net";
            Console.WriteLine(pathActual);
            string path = "c:\\program files\\Microsoft.Net";
            Console.WriteLine(path);
            //verbatim identifier for escape sequence
            string pathWithVerbatim = @"c:\program files\Microsoft.Net";
            Console.WriteLine(pathWithVerbatim);
            #endregion

            #region InterpolatedVerbatim

            int Base = 10;
            int Height = 30;
            int area = (Base * Height) / 2;

            // Here, @ token appears before $ token 
            // But the compiler will give an error 
            Console.WriteLine("Finding the area of a triangle:");
            Console.WriteLine(@$"Height = ""{Height}"" and Base = ""{Base}""");
            Console.WriteLine(@$"Area = ""{area}""");

          

            // Here, $ token appears before @ token 
            Console.WriteLine($@"Height = ""{Height}"" and Base = ""{Base}""");

            // Here, @ token appears before $ token 
            Console.WriteLine(@$"Area = ""{area}""");

            #endregion
        }
    }
}
