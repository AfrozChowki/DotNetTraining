using System;

namespace NullForgivingOperatorDemo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Person(string firstName, string lastName) => FirstName = firstName ?? throw new ArgumentNullException(nameof(FirstName));
    }
}
