using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenChecker
{
    class Program
    {
        /*
         * Create and initialize two ints.
         * Make a variable to work out the remainder.
         * Output remaindr to the screen.
         * Change the first int variable to another number
            * and recalculate the remainder.
            * and output new remainder to the screen.
        */
       
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 2;
            int remainder = num1 % num2;
            Console.WriteLine(remainder);

            num1 = 11;
            remainder = num1 % num2;
            Console.WriteLine(remainder);

            Console.ReadLine();
        }
    }
}
