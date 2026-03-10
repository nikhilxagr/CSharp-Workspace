using System;

namespace Neon_Number_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int sqr = num * num;

            while (sqr > 0)
            {
                int digit = sqr % 10;
                sum += digit;
                sqr /= 10;
            }
            if ( sum == num)
            {
                Console.WriteLine(num + " is a Neon Number.");
            }
            else
            {
                Console.WriteLine(num + " is not a Neon Number.");
            }
        }
    }
}



//Neon_Number is a number where the sum of the digits of its square is equal to the number itself.

//For example, 9 is a Neon Number because 9^2 = 81 and 8 + 1 = 9. In this program,

//we take an input number from the user, calculate its square, and then sum the digits of the squared number.
//Finally, we check if the sum is equal to the original number to determine if it is a Neon Number or not.