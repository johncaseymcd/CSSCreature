using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            string wholeName = "Douglas Crockford";

            string first = "The cars we sell are ";
            string second = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(first + second);

            string firstName = "Jenn";
            string lastName = "Williams";
            Console.WriteLine("Her name is {0} {1}.", firstName, lastName);

            string fName = "Robin";
            string lName = "Holler";
            Console.WriteLine($"Her name is {fName} {lName}.");

            Console.ReadLine();
        }
    }
}
