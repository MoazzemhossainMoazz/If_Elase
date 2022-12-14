using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            if (number % 2 == 0)
                Console.WriteLine("Even Number.");
            else
                Console.WriteLine("Odd Number");

            var output = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(output);

            int age = 44;

            if (age <= 17)
                Console.WriteLine("Kid");
            else if (age > 17 && age <= 50)
                Console.WriteLine("YoungMan");
            else
                Console.WriteLine("Old Man");

            //var season = season.winter;

            //switch (season)
            //{
            //    case season.Summer:
            //        break;
            //    case season.Rainy:
            //        break;
            //    case season.winter:
            //        break;
            //    case season.sprin:
            //        break;
            //}
            Console.ReadLine();
        }
    }
}
