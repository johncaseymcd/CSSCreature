using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Boolean_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 100 / 2; // Bronze challenge
            int value2 = 101 / 2; // Silver challenge
            float value3 = 101 % 2; // Silver challenge fix

            // Bronze challenge
            if (value == 50)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadLine();

            // Silver challenge
            if (value2 == 50)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // Silver challenge fix
            if (value3 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadLine();

            // Gold challenge
            Random rand = new Random();

            int randNum = rand.Next(100) + 1;
            Console.WriteLine("I'm thinking of a number between 1 and 100. Try to guess what it is!");

            int userNum = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (userNum < randNum)
                {
                    Console.WriteLine("Go higher!");
                    userNum = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
                else if (userNum > randNum)
                {
                    Console.WriteLine("Go lower!");
                    userNum = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
                else if (userNum > 100 || userNum < 1)
                {
                    Console.WriteLine("Your input was outside the parameters, try again!");
                    userNum = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
            }
            while (userNum != randNum);

            if (userNum == randNum)
            {
                Console.WriteLine("Amazing! You guessed correctly!");
                Console.ReadLine();
            }
        }
    }
}
