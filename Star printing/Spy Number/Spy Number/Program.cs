using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spy_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Spy Number Print 

            Console.WriteLine("Enter a number to check Spy Number:");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int product = 1;

            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;

                product *= digit;
                num /= 10;
            }
            if (num > 0)
            {
                Console.WriteLine("Spy Number");
            }
            else
            {
                Console.WriteLine("Not a Spy Number");

            }
        }
    }
}