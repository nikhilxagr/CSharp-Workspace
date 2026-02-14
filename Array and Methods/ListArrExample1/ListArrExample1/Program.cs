using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArrExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            Console.WriteLine("Array List Capacity:"+ arr.Capacity);
            Console.WriteLine("Array Element Count :" + arr.Count);
            Console.WriteLine("Adding 10 Prime Element:");
            arr.Add(2);
            arr.Add(3);
            arr.Add(5);
            arr.Add(7);
            arr.Add(11);
            arr.Add(13);
            arr.Add(15);
            arr.Add(17);
            arr.Add(19);
            arr.Add(23);
            Console.WriteLine("Capacity:"+arr.Capacity);
            Console.WriteLine("Count:"+ arr.Count);
            Console.WriteLine("Elements in Arraylist:");
            for (int i = 0; i < arr.Count; i++)
                Console.WriteLine(arr[i]);
            Console.WriteLine("Removing 2 Elements");
            arr.Remove(2);
            arr.Remove(3);
            Console.WriteLine("Capacity:" + arr.Capacity);
            Console.WriteLine("Elements :");

            foreach (int i in arr)
                Console.WriteLine(i);
            Console.WriteLine("Replacing 4 Elements:");
            arr[0] = 31;
            arr[1] = 37;
            arr[6] = 41;
            arr[7] = 43;
            Console.WriteLine("Elements in ArraList :");
            foreach(int i in arr)
                Console.WriteLine(i);
        }
    }
}
