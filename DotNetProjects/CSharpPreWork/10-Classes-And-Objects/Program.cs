using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Classes_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut dougDonut = new Donut();
            Donut chrisDonut = new Donut();
            Donut nickDonut = new Donut();

            dougDonut.filling = "cherry";
            dougDonut.price = 3;
            dougDonut.type = "normal";
            dougDonut.isSpecial = true;

            chrisDonut.filling = "none";
            chrisDonut.price = 2;
            chrisDonut.type = "small";
            chrisDonut.isSpecial = false;

            nickDonut.filling = "chocolate";
            nickDonut.price = 3;
            nickDonut.type = "normal";
            nickDonut.isSpecial = true;

            Console.WriteLine(nickDonut.filling);

            Console.ReadLine();
        }
    }
}
