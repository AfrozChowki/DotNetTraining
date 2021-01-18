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
            string[] employees = new string[] {"Maneesha", "Saitej", "Rajsekhar",
                "Emmanuel", "Chaitanya", "Venkat", "Afroz", "Kamal"};

            Console.Write("Name of the employees in project A: ");
            var P_A = employees[0..3];
            foreach (var emp1 in P_A)
                Console.Write($" [{emp1}]");

            Console.Write("\nName of the employees in project B: ");
            var P_B = employees[3..5];
            foreach (var emp2 in P_B)
                Console.Write($" [{emp2}]");

            Console.Write("\nName of the employees in project C: ");
            var P_C = employees[1..^1];
            foreach (var emp3 in P_C)
                Console.Write($" [{emp3}]");

            Console.Write("\nName of the employees in project D: ");
            var P_D = employees[..];
            foreach (var emp4 in P_D)
                Console.Write($" [{emp4}]");
        }
    }
}
