using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConstructorChaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person1 = new Person[3]
            {
                new Person("Harsh"),
                new Person("Amit", "Kumar"),
                new Person("Aditya", "Deshpande", 34)
            };


            foreach (Person person in person1)
            {
                Console.WriteLine(person.PrintDetails());
            }
        }
    }
}
