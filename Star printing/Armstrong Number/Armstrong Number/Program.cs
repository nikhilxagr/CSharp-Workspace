using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Armstrong Number Printing

            // 153 = 1^3 + 5^3 + 3^3 = 153


            Console.WriteLine("Enter a number :");
            int num = int.Parse(Console.ReadLine());
            int originalNum = num;
            int sum = 0;
            int digits = num.ToString().Length;

            while (num > 0)
            {
                int remainder = num % 10;
                sum += (int)Math.Pow(remainder, digits);
                num /= 10;
            }
            if (sum == originalNum)
            {
                Console.WriteLine("it is an Armstrong number.", originalNum);
            }
            else
            {
                Console.WriteLine("it is not an Armstrong number.", originalNum);
            }
            Console.ReadLine();
        }
    }
}
