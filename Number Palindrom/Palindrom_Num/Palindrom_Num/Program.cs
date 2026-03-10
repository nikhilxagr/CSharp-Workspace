using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it is a palindrome:");

            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int rev = 0;

            while (num > 0)
            {
                int digit = num % 10;   // Get the last digit
                rev = rev * 10 + digit;  // Append the digit to the reversed number
                num = num / 10;           // Remove the last digit

            }
            if (rev == temp)
            {
                Console.WriteLine("The number is a palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome.");
            }
        }
    }
}