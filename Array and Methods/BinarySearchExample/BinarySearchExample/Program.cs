using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BinarySearch Example

            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter " + n + " elements:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter element which you want to search: ");
            int key = Convert.ToInt32(Console.ReadLine());

            int low = 0;
            int high = n - 1;
            bool found = false;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == key)
                {
                    Console.WriteLine("Element found at index: " + mid);
                    found = true;
                    break;
                }
                else if (key < arr[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            if (!found)
            {
                Console.WriteLine("Element not found.");
            }
        }
    }
}
