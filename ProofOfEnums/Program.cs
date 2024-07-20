using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfEnums
{
    internal class Program
    {

        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }
        static void Main(string[] args)
        {
            DaysOfWeek today = DaysOfWeek.Saturday;
            Console.WriteLine($"Today is : {today}");

            Console.WriteLine((today == DaysOfWeek.Saturday || today == DaysOfWeek.Sunday) ? "It is Weekend" : "It is a Weekday");
        }
    }
}
