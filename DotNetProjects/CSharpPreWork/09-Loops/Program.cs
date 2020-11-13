using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (number <= 100)
            {
                Console.WriteLine(number);
                number = number + 5;
            }

            Console.ReadLine();

            number = 100;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
