using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, temp, sum, digit;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            while (num != 1 && num != 4)   // 4 means it will loop (not happy)
            {
                sum = 0;
                temp = num;

                while (temp > 0)
                {
                    digit = temp % 10;
                    sum = sum + (digit * digit);
                    temp = temp / 10;
                }

                num = sum;
            }

            if (num == 1)
                Console.WriteLine("Happy Number");
            else
                Console.WriteLine("Not a Happy Number");
        }
    }
}
