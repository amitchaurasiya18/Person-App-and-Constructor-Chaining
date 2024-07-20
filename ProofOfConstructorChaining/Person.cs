using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConstructorChaining
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public const string LAST_NAME = " ";
        public const int AGE = 20;

        public Person(string firstName) : this(firstName,LAST_NAME)
        {
            Console.WriteLine("One Parameter Constructor Called");          
        }

        public Person(string firstName, string lastName) : this(firstName,lastName,AGE)
        {
            Console.WriteLine("Two Parameter Constructor Called");
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Console.WriteLine("Three Parameter Constructor Called");
        }

        public string PrintDetails()
        {
            return $"Name : {FirstName} {LastName} , Age : {Age}";
        }
    }
}
