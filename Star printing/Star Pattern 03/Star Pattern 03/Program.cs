using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Pattern_03
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
            Console.ReadLine();
        }
    }
}

//Output

//    *
//   ***
//  *****
// *******
//*********