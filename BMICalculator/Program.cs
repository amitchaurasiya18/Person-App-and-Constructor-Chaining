using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Person[] person = new Person[4] {
                new Person(1, "Amit", 22),
                new Person(2, "Harsh", 24, 5.5, 75),
                new Person(3, "Golu", 30, 5.5, 120),
                new Person(1, "Bheem", 20),
            };

            foreach (Person p in person)
            {
                Console.WriteLine(p.PrintBMIStatus(p));
                Console.WriteLine($"Till now Maximum BMI is : {p.ReturnMaxBMI(person)}\n\n");
            }
        }
    }
}
