using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Loops_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bronze challenge
            for (int i = 500; i <= 525; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

            // Silver challenge
            for (int x = 0; x <= 100; x = x + 5)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();

            // Gold challenge
            for (int n = 1; n <= 100; n++)
            {
               if (n % 3 == 0 && n % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
               else if (n % 5 == 0 && n % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
               else if (n % 3 == 0 && n % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(n);
                }
            }

            Console.ReadLine();
        }
    }
}
