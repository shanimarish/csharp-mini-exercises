using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz Game");
            Console.WriteLine();
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool threeDiv = false;
            bool fiveDiv = false;

            threeDiv = number % 3 == 0;
            fiveDiv = number % 5 == 0;

            if (threeDiv && fiveDiv)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (threeDiv)
            {
                Console.WriteLine("Fizz");
            }
            else if (fiveDiv)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }

                Console.ReadLine();
        }
    }
}
