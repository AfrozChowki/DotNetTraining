using System;

namespace UnmanagedConstructedTypes
{
    /// <summary>
    /// Creating unmanaged constructed type that contains fields of unmanaged type only
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public struct Coords<T>
    {
        public T X;
        public T Y;
    }
    public class Program
    {
        public static unsafe void Main(string[] args)
        {
            var cords = new Coords<int> {X = 10, Y = 20};
            //pointer
            var bar = &cords;

            Console.WriteLine("Address is: {0}", (int)bar);

            // Block of memory   
            Span<Coords<int>> bars = stackalloc[]
            {
                new Coords<int> { X = 10, Y = 20 },
                new Coords<int> { X = 15, Y = 25 }
            };

            Console.ReadLine();
        }

    }
}
