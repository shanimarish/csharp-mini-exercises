using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Times Table");
            Console.WriteLine();
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{1} x {0} = {2}", i, number, i * number);
            }

            Console.ReadLine();
        }
    }
}
