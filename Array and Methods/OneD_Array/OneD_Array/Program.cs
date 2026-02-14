using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneD_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n]; 

            Console.WriteLine("Enter " + n + " elements:");

            // Taking input
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Display
            Console.WriteLine("Elements in the array are:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Element at index " + i + " = " + arr[i]);
            }
        }
    }
}
