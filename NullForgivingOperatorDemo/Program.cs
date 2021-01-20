using System;

namespace NullForgivingOperatorDemo
{
    class Program
    {
        public static void Main()
        {
            Person? p = new Person("test", null!);
            if (IsValid(p))
            {
                //p = null;
                string name = p!.FirstName ?? "testName";
                Console.WriteLine($"Found {name}");
            }
        }

        public static bool IsValid(Person? person)
        {
            return person != null && !string.IsNullOrEmpty(person.FirstName);
        }
    }
}
