using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetTraining.IndicesAndRangesDemo
{
    public class Company
    {
        public Company()
        {
            string[] employees = new string[] {"Maneesha", "Saitej", "Rajasekhar",
                "Emmanuel", "Chaitanya", "Venkat", "Afroz", "Kamal"};

            Console.Write("Name of the employees in project A: ");
            var projectA = employees[0..3];
            foreach (var emp1 in projectA)
                Console.Write($" [{emp1}]");

            Console.Write("\nName of the employees in project B: ");
            var projectB = employees[3..5];
            foreach (var emp2 in projectB)
                Console.Write($" [{emp2}]");

            Console.Write("\nName of the employees in project C: ");
            var projectC = employees[1..^1];
            foreach (var emp3 in projectC)
                Console.Write($" [{emp3}]");

            Console.Write("\nName of the employees in project D: ");
            var projectD = employees[..];
            foreach (var emp4 in projectD)
                Console.Write($" [{emp4}]");
        }
    }
}
