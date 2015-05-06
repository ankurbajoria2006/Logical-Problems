using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
            Console.ReadLine();
        }

        /// <summary>
        /// Program to write Fizz and buzz on multiples of 3,5 and 3-5.
        /// </summary>
        public static void FizzBuzz()
        {
            Console.WriteLine("Program to write Fizz and buzz on multiples of 3,5 and 3-5.");
            for (int input = 0; input <= 100; input++)
            {
                if (input%3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (input%5 == 0)
                {
                    Console.Write("Buzz");
                }
                if (input%3 != 0 && input%5 != 0)
                {
                    Console.Write(input);
                }
                Console.WriteLine();
            }
        }
    }
}
