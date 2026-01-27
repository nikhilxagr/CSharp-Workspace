using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start_Pattern_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i; space++)
                    Console.Write(" ");

                for (int star = 1; star <= 2 * i - 1; star++)
                    Console.Write("*");

                Console.WriteLine();
            }

            for ( int i = n ; i >= 1; i--)
            {
                for (int space = 1; space <= n - i; space++)
                    Console.Write(" ");

                for (int star = 1; star <= 2 * i - 1; star++)
                    Console.Write("*");
                 
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

//Output- Diamond Pattern 







