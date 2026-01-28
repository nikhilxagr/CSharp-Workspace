using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Perfect Number Printing 
            // 6 = 1 + 2 + 3 = 6
            
            Console.WriteLine("Enter a number to check Perfect Number: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0)
                        sum = sum + i;
                }

            if (sum == num)
            {
                Console.WriteLine(" it is Perfect Number");
            }
            else
            {
                Console.WriteLine("Not a Perfect Number");
            }
            Console.ReadLine();
        }
        
    }
}
