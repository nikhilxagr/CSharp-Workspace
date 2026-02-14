using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter " + n + " elements:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter element to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == search)
                {
                    Console.WriteLine("Element found at index: " + i);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Element not found.");
            }
        }
    }
}