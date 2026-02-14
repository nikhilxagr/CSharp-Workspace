using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            int i;

            Console.WriteLine("Enter 10 elements:");

            for (i = 0; i < 10; i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Original Array:");
            foreach (int j in x)
                Console.Write(j + " ");

            Console.WriteLine("\nArray After Sorting:");
            Array.Sort(x);
            foreach (int j in x)
                Console.WriteLine(" " + j);

            Console.WriteLine("\nArray After Reverse:");
            Array.Reverse(x);
            foreach (int j in x)
                Console.WriteLine(" " + j);

        }
    }
}
