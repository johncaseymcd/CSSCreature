using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthYear = 1994;
            int birthMonth;

            string name = "Casey McDonough";
            string birthday;

            bool isOver18 = true;
            bool isOver21;

            float age = 2020 - birthYear; //This should be an int but I couldn't think of anything to use a float for
            float months;

            double keyMash = 1654.06548487231d;
            double foo;

            decimal salary = 31260.00m;
            decimal acctBal;

            birthMonth = 2;
            birthday = "0" + birthMonth.ToString() + "/" + birthYear.ToString();

            Console.WriteLine(name);
            Console.WriteLine(birthday);
            Console.WriteLine(age);
            Console.WriteLine(salary);
            Console.ReadLine();
        }
    }
}
