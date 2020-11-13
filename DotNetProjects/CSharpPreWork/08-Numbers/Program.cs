using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bill = 54.23m;
            decimal tip = 12m;
            decimal percentage = tip / bill;

            Console.WriteLine(percentage);
            Console.WriteLine(Math.Round(percentage, 2));
            Console.WriteLine((Math.Round(percentage, 2) * 100) + "%");
            Console.ReadLine();
        }
    }
}
